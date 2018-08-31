using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageFinal.Entites;
using BoVoyageFinal.Dal;
using System.Configuration;
using System.Data.Entity;

namespace BoVoyageFinal.Services
{
    public class ServiceVoyage
    {
        public static void AfficherVoyage()
        {
            
            Console.WriteLine();
            Console.WriteLine(">Voyages :");
            using (var contexte = new Contexte())
            {
                var voyages = contexte.Voyages
                    .OrderBy(x => x.Id).ToList();
                
                foreach (var voyage in voyages)
                {
                    Console.WriteLine($"({voyage.Id}){voyage.PlacesDisponibles}{voyage.PrixParPersonne} {voyage.DateAller} {voyage.DateRetour} {voyage.IdDestination}");
                }
            }
        }
        public static void SupprimerVoyage()
        {
            Console.WriteLine();
            Console.WriteLine(">SUPPRESSION D'UNE MARQUE");

            Marque marque = ChoisirMarque();

            using (var contexte = new Contexte())
            {
                contexte.Marques.Attach(marque);
                contexte.Marques.Remove(marque);
                contexte.SaveChanges();
            }
        }
        public static void CreerVoyage()
        {
            Console.WriteLine();
            Console.WriteLine(">Enregistrer un NOUVEAU VOYAGE");

            ServiceDestination.AfficherDestination();
            Console.Write("Selectionner l'id de la destination : ");
            var dest = int.Parse(Console.ReadLine());

            Console.Write("Date et heure du départ : ");
            DateTime depart = DateTime.Parse(Console.ReadLine());

            Console.Write("Date et heure du retour : ");
            DateTime retour = DateTime.Parse(Console.ReadLine());

            Console.Write("Nombre de participant au voyage : ");
            var places = int.Parse(Console.ReadLine());

            Console.Write("Tarif par personne: ");
            var prix = int.Parse(Console.ReadLine());

            Console.Write("Quelle est l'agence fournisseur du voyage selectionné ? ");
            var agence = int.Parse(Console.ReadLine());


            var voyage = new Voyage();
            voyage.IdDestination = dest;
            voyage.DateAller = depart;
            voyage.DateRetour = retour;
            voyage.PlacesDisponibles = places;
            voyage.PrixParPersonne = prix;
            voyage.IdAgenceVoyage = agence;

            using (var contexte = new Contexte())
            {
                contexte.Voyages.Add(voyage);
                contexte.SaveChanges();
            }
        }
       

        public Destination GetDestination(int idDestination)
        {
            using (var contexte = new Contexte())
            {
                return contexte.Destinations.Single(x => x.Id == idDestination);

                    
            }
        }
        private static Destination ChoisirDestination()
        {
            AfficherVoyage();

            Console.WriteLine("Quel voyage souhaitez vous ?");
            var idDest = int.Parse(Console.ReadLine());

            var serviceVoyage= new ServiceVoyage();
            return serviceVoyage.GetDestination(idDest);
        }
        
    }
}
