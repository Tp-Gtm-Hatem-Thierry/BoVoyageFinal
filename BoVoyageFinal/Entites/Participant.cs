using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoVoyageFinal.Entites
{
    public class Participant
    {
        [Key]
        public int NumeroUnique { get; set; }
        public double Reduction { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Age { get; set; }
        public int IdDossierReservation { get; set; }

    }
}

