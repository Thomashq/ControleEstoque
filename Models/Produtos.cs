using SQLite;

namespace ControleEstoque.Models
{
    [Table("produtos")]
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200), Unique]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal PrecoCompra { get; set; }

        public decimal PrecoVenda { get; set; }

        public decimal EstoqueAtual { get; set; }

        public decimal EstoqueMinimo { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
