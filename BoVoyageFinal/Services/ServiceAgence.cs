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
        public static void AfficherAgences()
        {

            Console.WriteLine();
            Console.WriteLine("Liste des Agences :");
            using (var contexte = new Contexte())
            {
                var agences = contexte.AgencesVoyages
                    .OrderBy(x => x.Id).ToList();

                foreach (var agence in agences)
                {
                    Esthetisme.MiseEnFormeTexte($"({agence.Id}) {agence.Nom}",ConsoleColor.Yellow,centre:true);
                }
            }
        }
    }
}
