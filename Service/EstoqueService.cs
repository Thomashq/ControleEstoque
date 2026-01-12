using ControleEstoque.Data;
namespace ControleEstoque.Service
{
    public class BalancoEstoque
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int TotalEntradas { get; set; }
        public decimal ValorEntradas { get; set; }
        public int TotalSaidas { get; set; }
        public decimal ValorSaidas { get; set; }
        public int TotalProdutos { get; set; }
        public decimal ValorEstoqueAtual { get; set; }
        public int ProdutosAbaixoMinimo { get; set; }
        public decimal SaldoMovimentacao => ValorEntradas - ValorSaidas;
    }

    public class EstoqueService
    {
        private readonly DatabaseContext _database;

        public EstoqueService(DatabaseContext database)
        {
            _database = database;
        }

        public BalancoEstoque GetBalancoDiario()
        {
            var hoje = DateTime.Today;
            var amanha = hoje.AddDays(1);

            return GetBalancoPorPeriodo(hoje, amanha);
        }

        public BalancoEstoque GetBalancoPorPeriodo(DateTime inicio, DateTime fim)
        {
            var movimentacoes = _database.GetMovimentacoesPorPeriodo(inicio, fim);
            var produtos = _database.GetProdutos();

            var entradas = movimentacoes.Where(m => m.Tipo == "Entrada").ToList();
            var saidas = movimentacoes.Where(m => m.Tipo == "Saida").ToList();

            var balanco = new BalancoEstoque
            {
                DataInicio = inicio,
                DataFim = fim,
                TotalEntradas = entradas.Sum(e => e.Quantidade),
                ValorEntradas = entradas.Sum(e => e.ValorTotal),
                TotalSaidas = saidas.Sum(s => s.Quantidade),
                ValorSaidas = saidas.Sum(s => s.ValorTotal),
                TotalProdutos = produtos.Count,
                ValorEstoqueAtual = produtos.Sum(p => p.EstoqueAtual * p.PrecoCompra),
                ProdutosAbaixoMinimo = produtos.Count(p => p.EstoqueAtual < p.EstoqueMinimo)
            };

            return balanco;
        }
    }
}
