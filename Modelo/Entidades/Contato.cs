using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades
{
    [Table("CONTATOS")]
    public class Contato
    {
        public long? ContatoId { get; set; }
        public long NumeroTelefone { get; set; }
        public string Empresa { get; set; }
        public string Obscervacao { get; set; }
        public string TipoServico { get; set; }
    }
}
