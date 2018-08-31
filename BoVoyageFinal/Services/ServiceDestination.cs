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
    public class ServiceDestination
    {
        public void AfficherDestination()
        {
            Console.WriteLine();
            Console.WriteLine(">DESTINATION :");
            using (var contexte = new Contexte())
            {
                var destinations = contexte.Destinations
                .OrderBy(x => x.Id).ToList();
                foreach (var destination in destinations)
                {
                Console.WriteLine($"{destination.Continent} ({destination.Description})");
                }
            }
        }
    }
}
    
