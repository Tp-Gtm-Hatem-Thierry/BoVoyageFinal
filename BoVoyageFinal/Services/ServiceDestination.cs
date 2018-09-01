using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageFinal.Dal;
using BoVoyageFinal.Entites;


namespace BoVoyageFinal.Services
{
    class ServiceDestination
    {
        public static void AfficherDestination()
        {
            Console.WriteLine();
            Esthetisme.MiseEnFormeTexte(">Destination", ConsoleColor.DarkBlue, centre: false);
            using (var contexte = new Contexte())
            {
                var destinations = contexte.Destinations;
                foreach (var destination in destinations)
                {
                    Esthetisme.MiseEnFormeTexte($"({destination.Id}){destination.Continent}{destination.Pays} {destination.Region} {destination.Description}",ConsoleColor.Yellow,centre:true);
                }
            }
        }
    }
}
