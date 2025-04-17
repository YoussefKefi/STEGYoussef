using System.ComponentModel.DataAnnotations;
using STEGYoussef.ApplicationCore.Domains;
using STEGYoussef.Infrastructure;
using STEGYoussef.ApplicationCore.Domains;


var context = new STEGContext();

//context.Database.EnsureDeleted();
//context.Database.EnsureCreated();

var abonne = new Abonne
{
    CIN = "12345678",
    Nom = "Kefi",
    Prenom = "Youssef"
};
context.Abonnes.Add(abonne);

var compteur = new Compteur
{
    Reference = "CMP001",
    Type = TypeCompteur.Industriel,
    Voltage = 220,
    Index = 1500,
    AbonneCIN = abonne.CIN
};
context.Compteurs.Add(compteur);

var periode = new Periode
{
    Debut = new DateTime(2025, 1, 1),
    Fin = new DateTime(2025, 1, 31)
};
context.Periodes.Add(periode);
context.SaveChanges(); // ythabet periode.Id mawjouda

var facture = new Facture
{
    CompteurKey = compteur.Reference,
    PeriodeKey = periode.Id,
    Date = new DateTime(2025, 1, 15),
    Montant = 100.5,
    ConsommationKWH = 50,
    Payment = false
};
context.Factures.Add(facture);

context.SaveChanges();

Console.WriteLine("Données enregistrées.");