using System;
namespace BoVoyageFinal.Entites
    
{
    public class Client
    {
        public int Id { get; set; }
        
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Age { get; set; }
        public int IdDossierReservation { get; set; }
        public string Emal { get; set; }
    }
}

