                //Console.WriteLine("\nVotre identifiant qui est votre prenom, je vous pries");
                //var name = Console.ReadLine();
                //var date = DateTime.Now;
                //if (name != "Yannik")//une liste de commercial par exemple : Yannik
                //{
                //    string administrateur = ("gtm@gmail.com");
                //    {
                //        Console.WriteLine($"\n\aVous n'êtes pas autoriser à acceder à notre site intranet, veuillez vous rapprocher de votre administrateur, {administrateur} désolé !");
                //        Console.ReadKey();
                //    }
                //}
                //else
                //{
                //    Console.WriteLine($"\nBienvenu {name}, veuillez entrez votre mot de passe");
                //    var mdp = Console.ReadLine();
                //    if (mdp == "N_i$a3")//liste de mdp egalement... : N_i$a3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageFinal.Dal;
using System.Data.Entity;
using BoVoyageFinal.Services;

namespace BoVoyageFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Login();
            bool boucleMenu = true;
            Console.Clear();
            while (boucleMenu)
            {
                var choixMenuPrincipal = MenuPrincipal();
                switch (choixMenuPrincipal)
                {
                    case "1":
                        bool boucleVoyage = true;
                        Console.Clear();
                        while (boucleVoyage)
                        {

                            var choixMenuVoyage = MenuVoyage();
                            switch (choixMenuVoyage) // modification du nom des variables (choixMenu...)
                            {
                                case "1":
                                    Console.Clear();
                                    ServiceVoyage.AfficherVoyage();
                                    Console.WriteLine("Appuyez sur une touche pour revenir au menu");
                                    Console.ReadKey();
                                    Console.Clear();

                                    break;
                                case "2":
                                    Console.Clear();
                                    ServiceVoyage.CreerVoyage();
                                    Console.WriteLine("Voyage Ajouté ! \nAppuyez sur une touche pour revenir au menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Clear();
                                    ServiceVoyage.SupprimerVoyage();
                                    Console.WriteLine("Voyage supprimé ! \nAppuyez sur une touche pour revenir au menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "4":
                                    Console.Clear();
                                    ServiceDestination.AfficherDestination();
                                    Console.WriteLine("Appuyez sur une touche pour revenir au menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.Clear();
                                    ServiceAgence.AfficherAgences();
                                    Console.WriteLine("Appuyez sur une touche pour revenir au menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "6":
                                    boucleVoyage = false;
                                    break;

                            }
                        }
                        break;
                    case "2":
                        bool boucleClient = true;
                        Console.Clear();
                        while (boucleClient)
                        {

                            var choixMenuClient = MenuClient();
                            switch (choixMenuClient)
                            {
                                case "1":
                                    //ListeOffres();
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    boucleClient = false;
                                    break;
                            }
                        }
                        break;
                    case "3":
                        boucleMenu = false;
                        break;
                    default:
                        Console.WriteLine("Choix invalide, veuiller recommencer");
                        Console.ReadKey();
                        break;
                }
            }

        }
        public static string MenuPrincipal()
        {
            Console.Clear();
            { 
                Entites.Esthetisme.MiseEnFormeTexte("APPLICATION INTRANET DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
                Console.WriteLine(" 1. Gestion de BoVoyage\n");
                Console.WriteLine(" 2. Gestion Reservations\n");
                Console.WriteLine(" 3. Quitter BoVoyage\n");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("\nQuel est vôtre choix ?\n");

                return Console.ReadLine();
            }
        }
        static string MenuVoyage()
        {

            Console.WriteLine("Gestion de BoVoyage\n\n");
            Console.WriteLine(" 1. Liste de nos offres\n");
            Console.WriteLine(" 2. Ajouter une offre\n");
            Console.WriteLine(" 3. Supprimer une offre\n");
            Console.WriteLine(" 4. Afficher les destinations\n");
            Console.WriteLine(" 5. Afficher les agences de voyage\n");
            Console.WriteLine(" 6. Retour\n");
            Console.Write("\nQuel est vôtre choix ?\n ");

            return Console.ReadLine();
        }
        static string MenuClient()
        {
            Console.WriteLine("vous ête sur la page : Gestion de nos clients\n\n");
            Console.WriteLine(" 1. Nouvelles reservations\n");
            Console.WriteLine(" 2. Liste de nos Clients\n");
            Console.WriteLine(" 3. Campagne emailing\n");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" 4. Retour\n");

            return Console.ReadLine();
        }
        static void Login()
        {
            string administrateur = ("gtm@gmail.com");
            var date = DateTime.Now;
            
            Console.WriteLine("\nVotre identifiant qui est votre prenom, je vous pries");
            var name = Console.ReadLine();
           
            if (name != "Yannick")//pas suffisament de temps pour ajouter une liste : Yannick
            {
                {
                    Console.WriteLine($"\n\aVous n'êtes pas autoriser à acceder à notre site intranet, veuillez vous rapprocher de votre administrateur, {administrateur} désolé !");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine($"\nBienvenu {name}, veuillez tapez votre mot de passe");
                var mdp = Console.ReadLine();
                bool boucleMdp = true;

                while (boucleMdp)
                {
                    if (mdp == "N_i$a3")
                    {
                        boucleMdp = false;
                    }
                    else
                    {
                    Console.WriteLine($"\n{name}, merci de rééssayer avec le mot de passe suivant : N_i$a3");
//                   Console.Clear();
// regler le problem de boucle infini
                    }
                }
            }
        }

    }
}
