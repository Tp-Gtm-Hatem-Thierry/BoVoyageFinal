using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageFinal.Dal;
using BoVoyageFinal.Entites;


namespace BoVoyageFinal.Services
{
    public class ServiceReservation
    {
        static void NouvelleReservation()
        {
            Console.WriteLine();
            Esthetisme.MiseEnFormeTexte(">NOUVELLE RESERVATION",ConsoleColor.DarkBlue,centre:false);

            Console.Write("Selectionner l'id de la destination : ");
            var dest = int.Parse(Console.ReadLine());

            Console.Write("Date et heure du départ : ");
            DateTime depart = DateTime.Parse(Console.ReadLine());

            Console.Write("Date et heure du retour : ");
            DateTime retour = DateTime.Parse(Console.ReadLine());

            Console.Write("Nombre de places disponibles : ");
            var places = int.Parse(Console.ReadLine());

            Console.Write("Tarif par personne : ");
            var prix = int.Parse(Console.ReadLine());

            Console.Write("Quelle est l'agence fournisseur du voyage selectionné ?\n ");
            ServiceAgence.AfficherAgences();
            var agence = int.Parse(Console.ReadLine());
        }
    }
}


