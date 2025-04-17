using System.ComponentModel.DataAnnotations;
using STEGYoussef.ApplicationCore.Domains;

namespace STEGYoussef.ApplicationCore.Domains
{
    public enum TypeCompteur
    {
        Domestique,
        Industriel,
        Autre
    }
    public class Compteur
    {
        [Key]
        public string Reference { get; set; }

        public TypeCompteur Type { get; set; }

        public float Voltage { get; set; }

        public long Index { get; set; }

        public virtual Abonne Abonne { get; set; }

        public virtual IList<Facture> Factures { get; set; }
    }
}