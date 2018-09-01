namespace BoVoyageFinal.Entites
{
    internal class AfficherMenu
    {        Login();
        bool boucleMenu = true;
        Console.Clear();
            while (boucleMenu)
            {
                var choixMenuPrincipal = MenuPrincipal();
                switch (choixMenuPrincipal)
                {
                    case 1:
                        bool boucleVoyage = true;
        Console.Clear();
                        while (boucleVoyage)
                        {
                            string retourMenu = "\nAppuyez sur une touche pour revenir au menu";
        var choixMenuVoyage = MenuVoyage();
                            switch (choixMenuVoyage)
                            {
                                case 1:
                                    Console.Clear();
                                    ServiceVoyage.AfficherVoyage();
                                    Console.WriteLine(retourMenu);
                                    Console.ReadKey();
                                    Console.Clear();

                                    break;
                                case 2:
                                    Console.Clear();
                                    ServiceVoyage.CreerVoyage();
                                    Console.WriteLine("Voyage Ajouté !",retourMenu);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    ServiceVoyage.SupprimerVoyage();
                                    Console.WriteLine("Voyage supprimé !",retourMenu);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.Clear();
                                    ServiceDestination.AfficherDestination();
                                    Console.WriteLine(retourMenu);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 5:
                                    Console.Clear();
                                    ServiceAgence.AfficherAgences();
                                    Console.WriteLine(retourMenu);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 6:
                                    boucleVoyage = false;
                                    break;

                            }
}
                        break;
                    case 2:
                        bool boucleClient = true;
Console.Clear();
                        while (boucleClient)
                        {

                            var choixMenuClient = MenuClient();
                            switch (choixMenuClient)
                            {
                                case 1:
                                    Console.Clear();
                                    ServiceClient.AjouterReservation();
                                    break;
                                case 2:
                                    Console.Clear();
                                    ServiceClient.AfficherClient();
                                    Console.ReadKey();

                                    break;
                                case 3:
                                    break;
                                case 4:
                                    boucleClient = false;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        boucleMenu = false;
                        break;
                    default:
                        Entites.Esthetisme.MiseEnFormeTexte("Choix invalide, veuiller recommencer", ConsoleColor.Red, centre:true);
                        Console.ReadKey();
                        break;
                }
            }

        }
        public static int MenuPrincipal()
{
    Console.Clear();
    {
        Entites.Esthetisme.MiseEnFormeTexte("APPLICATION INTRANET DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
        Console.WriteLine(". 1 . Gestion de vos Voyages\n");
        Console.WriteLine(". 2 . Gestion de vos Clients\n");
        Console.WriteLine(". 3 . Quitter l'intranet de BoVoyage");

        Console.WriteLine("");
        Console.WriteLine("");
        Entites.Esthetisme.MiseEnFormeTexte("Quel est le numéro de vôtre choix ?\n", ConsoleColor.Yellow, centre: true);

        return int.Parse(Console.ReadLine());
    }
}
static int MenuVoyage()
{

    Entites.Esthetisme.MiseEnFormeTexte("page : Gestion de nos offres voyage\n\n", ConsoleColor.DarkCyan, centre: true);
    Console.WriteLine(". 1 . Liste de nos offres\n");
    Console.WriteLine(". 2 . Ajouter une offre\n");
    Console.WriteLine(". 3 . Supprimer une offre\n");
    Console.WriteLine(". 4 . Afficher les destinations\n");
    Console.WriteLine(". 5 . Afficher les agences de voyage\n");
    Console.WriteLine(". 6 . Retour");
    Entites.Esthetisme.MiseEnFormeTexte("Quel est le numéro de vôtre choix ?", ConsoleColor.Yellow, centre: true);

    return int.Parse(Console.ReadLine());
}
static int MenuClient()
{
    Entites.Esthetisme.MiseEnFormeTexte("page : Gestion de nos clients\n\n", ConsoleColor.DarkCyan, centre: false);
    Console.WriteLine(". 1 . Ajouter une reservation (en cours)\n");
    Console.WriteLine(". 2 . Liste de nos Clients\n");
    Console.WriteLine(". 3 . Liste des participants (Pour la v.3.0) \n");
    Console.WriteLine(". 4 . Consulter Modifier (Pour la v.3.0) \n");
    Console.WriteLine(". 5 . Campagne emailing (Pour la v.3.0) \n");

    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine(". 4 . Retour\n");
    Entites.Esthetisme.MiseEnFormeTexte("Quel est le numéro de vôtre choix ?", ConsoleColor.Yellow, centre: true);

    return int.Parse(Console.ReadLine());
}
static void Login()
{
    string administrateur = ("gtm@gmail.com");
    var date = DateTime.Now;
    string id = "Yannick";


    //pas suffisament de temps pour ajouter une liste d'identifiant
    bool boucleId = true;
    while (boucleId)
    {
        Console.WriteLine("\nVeuillez taper votre identifiant je vous pries :");
        string name = Console.ReadLine();

        if (name != id)
        {
            Entites.Esthetisme.MiseEnFormeTexte($"\n\aVous n'êtes pas autoriser à acceder à notre site intranet, veuillez vous rapprocher de votre administrateur, {administrateur} désolé !", ConsoleColor.DarkRed, centre: false);
            Entites.Esthetisme.MiseEnFormeTexte("Recommencez", ConsoleColor.Gray, centre: true);
        }

        else
        {
            boucleId = false;
        }
    }
    Console.Clear();
    bool boucleMdp = true;
    while (boucleMdp)
    {
        Console.WriteLine("Veuillez tapez votre mot de passe :");
        var mdp = Console.ReadLine();
        //pas suffisament de temps pour ajouter une liste de mots de passe
        if (mdp != "N_i$a3")
        {
            Entites.Esthetisme.MiseEnFormeTexte($"\n\aVous n'êtes pas autoriser à acceder à notre site intranet, veuillez vous rapprocher de votre administrateur, {administrateur} désolé !", ConsoleColor.DarkRed, centre: false);
            Entites.Esthetisme.MiseEnFormeTexte($"{id}, veuillez tapez le mot de passe suivant : N_i$a3", ConsoleColor.Yellow, centre: true);
        }
        else
        {
            Entites.Esthetisme.MiseEnFormeTexte($"Bienvenu {id} !", ConsoleColor.Cyan, centre: true);
            Entites.Esthetisme.MiseEnFormeTexte("Merci d'appuyer sur une touche pour acceder au site intranet de BoVoyage. " + date, ConsoleColor.Cyan, centre: true);
            Console.ReadKey();
            boucleMdp = false;
        }
    }

}

    }
}