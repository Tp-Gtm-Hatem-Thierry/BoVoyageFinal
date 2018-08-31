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
    public class ServiceAgence
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
}
