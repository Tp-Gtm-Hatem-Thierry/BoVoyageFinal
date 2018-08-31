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
                //var dest = contexte.Destinations.ToList();
                var voyages = contexte.Voyages
                    .OrderBy(x => x.Id).ToList();
                
                foreach (var voyage in voyages)
                {
                    Console.WriteLine($"({voyage.Id}){voyage.PlacesDisponibles}{voyage.PrixParPersonne} {voyage.DateAller} {voyage.DateRetour} {voyage.IdDestination}");
                }
            }
        }
        private static void CreerVoyage()
        {
            Console.WriteLine();
            Console.WriteLine(">NOUVELLE VOYAGE");

            AfficherVoyage();
            Console.Write("Id du voyage: ");
            var id = int.Parse(Console.ReadLine());

            ServiceDestination.AfficherDestination();
            Console.Write("Quelle l'id de la destination: ");
            var dest = int.Parse(Console.ReadLine());

            Console.Write("Date et heure du départ: ");
            DateTime depart = DateTime.Parse(Console.ReadLine());

            Console.Write("Date et heure du retour: ");
            DateTime retour = DateTime.Parse(Console.ReadLine());

            Console.Write("Nombre de places disponibles: ");
            var places = int.Parse(Console.ReadLine());

            Console.Write("Prix par personne: ");
            var prix = int.Parse(Console.ReadLine());

            Console.Write("Quelle agence fournit le voyage ? ");
            var agence = int.Parse(Console.ReadLine());


            var voyage = new Voyage();
            voyage.Id = id;
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
        //private static void -Objet-()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("-Menu-");

        //    Classe objet = methode();

        //    using (var contexte = new Contexte())
        //    {
        //        contexte.Classe.Attach(objet);
        //        contexte.Classe.Remove(objet);
        //        contexte.SaveChanges();
        //    }
        //}

        public Destination GetDestination(int idDestination)
        {
            using (var contexte = new Contexte())
            {
                return contexte.Destinations.Single(x => x.Id == idDestination);

                    //.Include(x => x.Modeles)
                    //.Single(x => x.Id == idMarque);
            }
        }
        private static Destination ChoisirDestination()
        {
            AfficherVoyage();

            Console.WriteLine("Quel voyage?");
            var idDest = int.Parse(Console.ReadLine());

            var serviceVoyage= new ServiceVoyage();
            return serviceVoyage.GetDestination(idDest);
        }
        
    }
}
