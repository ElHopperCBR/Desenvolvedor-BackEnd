using System.ComponentModel.DataAnnotations;

namespace CasasBahia.Classes.Models.Entidades
{
    public class Logins
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30), MinLength(3)]
        public string Usuario { get; set; }

        [Required, MaxLength(10), MinLength(6)]
        public string Senha { get; set; }

        [Required, MaxLength(10)]
        public string Regra { get; set; }
    }
}
