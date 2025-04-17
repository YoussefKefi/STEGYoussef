using System.ComponentModel.DataAnnotations;
using STEGYoussef.ApplicationCore.Domains;

namespace STEGYoussef.ApplicationCore.Domains
{
    public class Abonne
    {
        [Key]
        public string CIN { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        public virtual IList<Compteur> Compteurs { get; set; }
    }
}