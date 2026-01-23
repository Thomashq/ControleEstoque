using ControleEstoque.Models;
using SQLite;

namespace ControleEstoque.Data
{
    public class DatabaseContext
    {
        private readonly SQLiteConnection _database;

        public DatabaseContext()
        {
            var appDataDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ControleEstoque"
            );

            if (!Directory.Exists(appDataDir))
                Directory.CreateDirectory(appDataDir);

            var dbPath = Path.Combine(appDataDir, "estoque.db");

            var dbOrigem = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "estoque.db"
            );

            if (!File.Exists(dbPath))
                File.Copy(dbOrigem, dbPath);

            _database = new SQLiteConnection(dbPath);

            _database.CreateTable<Produto>();
            _database.CreateTable<Movimentacao>();
        }

        public List<Produto> GetProdutos()
        {
            return _database.Table<Produto>().OrderBy(p => p.Id).ToList();
        }

        public Produto GetProduto(int id)
        {
            return _database.Table<Produto>().FirstOrDefault(p => p.Id == id);
        }

        public int SaveProduto(Produto produto)
        {
            if (produto.Id != 0)
                return _database.Update(produto);
            else
                return _database.Insert(produto);
        }

        public int DeleteProduto(Produto produto)
        {
            return _database.Delete(produto);
        }

        public List<Movimentacao> GetMovimentacoes()
        {
            var movimentacoes = _database.Table<Movimentacao>()
                .OrderByDescending(m => m.DataMovimentacao)
                .ToList();

            foreach (var mov in movimentacoes)
            {
                var produto = GetProduto(mov.ProdutoId);
                mov.NomeProduto = produto?.Nome ?? "Produto não encontrado";
            }

            return movimentacoes;
        }

        public List<Movimentacao> GetMovimentacoes(DateTime? data, string nomeProduto)
        {
            var movimentacoes = _database.Table<Movimentacao>().ToList();

            // filtro por data
            if (data.HasValue)
            {
                movimentacoes = movimentacoes
                    .Where(m => m.DataMovimentacao.Date == data.Value.Date)
                    .ToList();
            }

            // carregar nome do produto
            foreach (var mov in movimentacoes)
            {
                var produto = GetProduto(mov.ProdutoId);
                mov.NomeProduto = produto?.Nome ?? "Produto não encontrado";
            }

            // filtro por nome do produto (depois de carregar o nome)
            if (!string.IsNullOrWhiteSpace(nomeProduto))
            {
                movimentacoes = movimentacoes
                    .Where(m => m.NomeProduto
                        .Contains(nomeProduto, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return movimentacoes
                .OrderByDescending(m => m.DataMovimentacao)
                .ThenByDescending(m => m.HoraMovimentacao)
                .ToList();
        }


        public int SaveMovimentacao(Movimentacao movimentacao)
        {
            var produto = GetProduto(movimentacao.ProdutoId);

            if (produto != null)
            {
                if (movimentacao.Tipo == "Entrada")
                    produto.EstoqueAtual += movimentacao.Quantidade;
                else
                    produto.EstoqueAtual -= movimentacao.Quantidade;

                SaveProduto(produto);
            }

            if (movimentacao.Id == 0)
            {
                if (movimentacao.DataMovimentacao == DateTime.MinValue)
                    movimentacao.DataMovimentacao = DateTime.Today;

                if (movimentacao.HoraMovimentacao == TimeSpan.Zero)
                    movimentacao.HoraMovimentacao = DateTime.Now.TimeOfDay;

                return _database.Insert(movimentacao);
            }

            return _database.Update(movimentacao);
        }
        public int DeleteMovimentacao(Movimentacao movimentacao)
        {
            var produto = GetProduto(movimentacao.ProdutoId);

            if (produto != null)
            {
                // desfaz o efeito da movimentação
                if (movimentacao.Tipo == "Entrada")
                    produto.EstoqueAtual -= movimentacao.Quantidade;
                else
                    produto.EstoqueAtual += movimentacao.Quantidade;

                SaveProduto(produto);
            }

            return _database.Delete(movimentacao);
        }

        public List<Produto> GetProdutos(string filtroNome)
        {
            var query = _database.Table<Produto>();

            if (!string.IsNullOrWhiteSpace(filtroNome))
            {
                query = query.Where(p => p.Nome.Contains(filtroNome));
            }

            return query.OrderBy(p => p.Id).ToList();
        }
        public List<Movimentacao> GetMovimentacoesPorPeriodo(DateTime inicio, DateTime fim)
        {
            var movimentacoes = _database.Table<Movimentacao>()
                .ToList()
                .Where(m =>
                {
                    var dataHora = m.DataMovimentacao.Date + m.HoraMovimentacao;
                    return dataHora >= inicio && dataHora <= fim;
                })
                .OrderBy(m => m.DataMovimentacao)
                .ThenBy(m => m.HoraMovimentacao)
                .ToList();

            foreach (var mov in movimentacoes)
            {
                var produto = GetProduto(mov.ProdutoId);
                mov.NomeProduto = produto?.Nome ?? "Produto não encontrado";
            }

            return movimentacoes;
        }
    }
}
