using System.ComponentModel.DataAnnotations;

namespace foraneoApp.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string tipoUsuario { get; set; }
        public string? cedula { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? email { get; set; }
        public string? carrera { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateTimeSignUp { get; set; }
    }
}
