using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STEGYoussef.ApplicationCore.Domains;


namespace STEGYoussef.ApplicationCore.Interfaces
{
    public interface IFactureService
    {
        float GetMontantTotalFacturesNonPayees();
        IList<Facture> GetFacturesNonPayeesParAbonne(string abonneCIN);
        double GetMoyenneConsommationParType(TypeCompteur type);
        IList<Abonne> GetTop3ConsommateursParPeriode(int periodeId);
    }
}

