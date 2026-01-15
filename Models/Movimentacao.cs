using SQLite;

namespace ControleEstoque.Models
{
    [Table("movimentacoes")]
    public class Movimentacao
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public string Tipo { get; set; }

        public decimal Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public string Observacao { get; set; }

        public DateTime DataMovimentacao { get; set; }

        public TimeSpan HoraMovimentacao { get; set; }

        [Ignore]
        public string NomeProduto { get; set; }

        [Ignore]
        public decimal ValorTotal => Quantidade * ValorUnitario;

        [Ignore]
        public DateTime DataHoraMovimentacao =>
            DataMovimentacao.Date + HoraMovimentacao;
    }
}

