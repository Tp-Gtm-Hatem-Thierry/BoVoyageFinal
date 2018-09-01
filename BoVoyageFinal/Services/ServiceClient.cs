using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageFinal.Entites;
using BoVoyageFinal.Dal;

namespace BoVoyageFinal.Services
{
    class ServiceClient

    {
        public static void AfficherClient()
        {

            Console.WriteLine();
            Console.WriteLine("Liste des clients :");
            using (var contexte = new Contexte())
            {
                var clients = contexte.Clients
                    .OrderBy(x => x.Id).ToList();

                foreach (var client in clients)
                {
                    Esthetisme.MiseEnFormeTexte($"({client.Id}){client.Civilite} {client.Nom} {client.Prenom} {client.DateNaissance} {client.Email}",ConsoleColor.Cyan,centre:true);
                }
            }
        }
        public static void AfficherAssurance()
        {

            Console.WriteLine();
            Console.WriteLine(">Assurances :");
            using (var contexte = new Contexte())
            {
                var assurances = contexte.Assurances
                    .OrderBy(x => x.Id).ToList();

                foreach (var assurance in assurances)
                {
                    Console.WriteLine($"({assurance.Id})  {assurance.Annulation}  {assurance.Montant}");
                }
            }
        }
        

        public static void AjouterReservation()
        {
            Console.WriteLine();
            Console.WriteLine(">Ajouter un nouveau client :\n");
            var client = new Client();
            var dossier = new DossierReservation();


            Console.Write("Civilité : \n");
            Console.WriteLine(". 1 .Monsieur");
            Console.WriteLine(". 2 .Madame");
            Console.WriteLine(". 3 .Non Renseigné");
            var civilite = Console.ReadLine();
//            string civilite;
            bool continuer = true;
            while(continuer)
            {
                switch (int.Parse(civilite))
                {
                case 1:
                        civilite = "Monsieur";
                        continuer = false;
                         break;
                case 2:
                        civilite = "Madame";
                        continuer = false;
                        break;
                case 3:
                        civilite = "Non Renseigné";
                        continuer = false;
                        break;
                default:
                        Console.WriteLine("Choix invalide Recommencez");
                        break;
                }

            }
            
            Console.WriteLine("Nom : ");
            var nom = Console.ReadLine();

            Console.WriteLine("Prenom : ");
            var prenom = Console.ReadLine();

            Console.WriteLine("Date de Naissance : ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            var auj = DateTime.Now;
            TimeSpan duree = auj - date;
            double ageJour = duree.TotalDays;
            double ageAnnee = ageJour / 365;
            int age = (int)ageAnnee;

            Console.WriteLine("Adresse : ");
            var adresse = Console.ReadLine();

            Console.WriteLine("Email : ");
            var email = Console.ReadLine();

            Console.WriteLine("Telephone : \n");
            var tel = Console.ReadLine();

            client.Nom = nom;
            client.Prenom = prenom;
            client.DateNaissance = date;
            client.Age = age;
            client.Adresse = adresse;
            client.Email = email;
            client.Telephone = tel;
            Console.Clear();


            Console.WriteLine("Reservation : \n");

            Console.WriteLine("Veuillez Selectionner l'id du voyage :");
            ServiceVoyage.AfficherVoyage();
            var idVoyage = int.Parse(Console.ReadLine());

            Console.Clear();
            AfficherAssurance();
            Console.WriteLine("Veuillez Selectionner l'id de l'assurance : \n");
            var idAssurance = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez choisir le nombre de Participants : \n");
            var nbParticipant = int.Parse(Console.ReadLine());

            Console.WriteLine("Et voila on arrive au bout du code :(");

            Console.ReadKey();

            dossier.IdAssurance = idAssurance;
            dossier.IdVoyage = idVoyage;
            
            using (var contexte = new Contexte())
            {
                contexte.Clients.Add(client);
                contexte.DossiersReservations.Add(dossier);
                contexte.SaveChanges();
            }
            

            

        }
    }
}

