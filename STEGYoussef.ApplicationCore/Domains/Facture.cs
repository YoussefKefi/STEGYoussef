using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STEGYoussef.ApplicationCore.Domains
{
    public class Facture
    {
        public DateTime Date { get; set; }

        public double Montant { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La consommation doit être un nombre positif")]
        public int ConsommationKWH { get; set; }

        public bool Payment { get; set; }

        public string CompteurKey { get; set; }

        public int PeriodeKey { get; set; }

        public virtual Compteur Compteur { get; set; }

        public virtual Periode Periode { get; set; }
    }
}