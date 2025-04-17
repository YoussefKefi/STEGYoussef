using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using STEGYoussef.ApplicationCore.Domains;

namespace STEGYoussef.ApplicationCore.Domains
{
    public class Periode
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Debut { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fin { get; set; }

        public virtual IList<Facture> Factures { get; set; }
    }
}