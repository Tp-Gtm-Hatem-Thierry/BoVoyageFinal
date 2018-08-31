using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageFinal.Dal;

namespace BoVoyageFinal.Services
{
    class ServiceDestination
    {
        public static void AfficherDestination()
        {

            Console.WriteLine();
            Console.WriteLine(">Destinations :");
            using (var contexte = new Contexte())
            {

                var destinations = contexte.Destinations;
                    //.OrderBy(x => x.Id).ToList();

                foreach (var destination in destinations)
                {
                    Console.WriteLine($"({destination.Id}){destination.Continent}{destination.Pays} {destination.Region} {destination.Description}");
                }
            }
        }
    }
}
