using STEGYoussef.ApplicationCore.Domains;
using STEGYoussef.Infrastructure;
using Microsoft.EntityFrameworkCore;
using STEGYoussef.ApplicationCore.Domains;
using STEGYoussef.Infrastructure;

namespace STEG.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Initialisation de la base de données STEG...");

            // Créer une instance du contexte qui utilise la chaîne de connexion définie dans OnConfiguring
            STEGContext context = new STEGContext();

            // Forcer la création de la base de données
            context.Database.EnsureDeleted(); // Supprime d'abord la base si elle existe
            context.Database.EnsureCreated(); // Crée la base de données avec le schéma défini

            System.Console.WriteLine("Base de données STEGYoussefKefi créée avec succès!");

            // Ajouter des données de test
            var abonne = new Abonne
            {
                CIN = "12345678",
                Nom = "Kefi",
                Prenom = "Youssef"
            };

            var compteur = new Compteur
            {
                Reference = "COMP001",
                Type = TypeCompteur.Domestique,
                Voltage = 220.0f,
                Index = 1000,
                Abonne = abonne
            };

            var periode = new Periode
            {
                Debut = new DateTime(2025, 1, 1),
                Fin = new DateTime(2025, 1, 31)
            };

            context.Abonnes.Add(abonne);
            context.Compteurs.Add(compteur);
            context.Periodes.Add(periode);

            context.SaveChanges();

            System.Console.WriteLine("Données de test ajoutées avec succès!");
        }
    }
}