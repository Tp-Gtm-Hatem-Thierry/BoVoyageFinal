using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageFinal.Entites
{
    class Esthetisme
    {
        public static void MiseEnFormeTexte(string message, ConsoleColor couleur = ConsoleColor.Gray, bool centre = false)
        {
            Console.ForegroundColor = couleur;
            if (centre)
            {
                int nbEspaces = (Console.WindowWidth - message.Length) / 2;
                Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            }
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
