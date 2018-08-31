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
            Esthetisme.MiseEnFormeTexte("Voyages :",ConsoleColor.DarkCyan, centre : true);
            using (var contexte = new Contexte())
            {
                var voyages = contexte.Voyages
                    .OrderBy(x => x.Id).ToList();
                
                foreach (var voyage in voyages)
                {
                    Console.WriteLine($"({voyage.Id}){voyage.PlacesDisponibles}  {voyage.PrixParPersonne}  {voyage.DateAller}  {voyage.DateRetour}  {voyage.IdDestination}");
                }
            }
        }
        public static void SupprimerVoyage()
        {
            AfficherVoyage();
            Console.WriteLine("");
            Esthetisme.MiseEnFormeTexte("Selectionnez l'Id du voyage à supprimer ?",ConsoleColor.Yellow,centre:true);
            var idvoyage = int.Parse(Console.ReadLine());

            using (var contexte = new Contexte())
            {
                Voyage voyage = contexte.Voyages.Single(x => x.Id == idvoyage);
                contexte.Voyages.Attach(voyage);
                contexte.Voyages.Remove(voyage);
                contexte.SaveChanges();
            }
            
            
        }
        public static void CreerVoyage()
        {
            Console.WriteLine();
            Esthetisme.MiseEnFormeTexte("Enregistrer un NOUVEAU VOYAGE\n",ConsoleColor.DarkCyan, centre:true);

            ServiceDestination.AfficherDestination();
            Console.Write("Selectionner l'id de la destination : ");
            var dest = int.Parse(Console.ReadLine());

            Console.Write("Date et heure du départ : ");
            DateTime depart = DateTime.Parse(Console.ReadLine());

            Console.Write("Date et heure du retour : ");
            DateTime retour = DateTime.Parse(Console.ReadLine());

            Console.Write("Nombre de places disponibles : ");
            var places = int.Parse(Console.ReadLine());

            Console.Write("Tarif par personne: ");
            var prix = int.Parse(Console.ReadLine());

            Console.Write("Quelle est l'agence fournisseur du voyage que vous avez selectionné ?\n ");
            ServiceAgence.AfficherAgences();
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
        
    }
}
