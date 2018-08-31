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
            Console.WriteLine(">VOYAGE :");
            using (var contexte = new Contexte())
            {
                var voyages = contexte.Voyages
                    .OrderBy(x => x.Id).ToList();
                
                foreach (var voyage in voyages)
                {
                    Console.WriteLine($"{voyage.DateAller} ({voyage.DateRetour})");
                }
            }
        }
    }
}
