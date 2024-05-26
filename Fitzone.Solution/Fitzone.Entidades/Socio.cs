using System.ComponentModel.DataAnnotations;

namespace Fitzone.Entidades
{
    public class Socio
    {

        [Key]
        public int idSocio { get; set; }
        
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string numeroDocumento { get; set; }
        public string? telefono1 { get; set; }
        public string? telefono2 { get; set; }
        public string? mail { get; set; }
        public string tipoDocumento { get; set; }
        public string? calle { get; set; }
        public string? calleNumero{ get; set; }
        public int idBarrio { get; set; }

    }
}
