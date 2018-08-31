using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoVoyageFinal.Entites
{
    [Table("DossiersReservations")]
    public class DossierReservation
    {
        [Key] //positionement de la clé primaire
        public int NumeroUnique { get; set; }
        public string NumeroCarteBancaire { get; set; }
        public int PrixParPersonne { get; set; }
        public int PrixTotal { get; set; }
        public int EtatDossierReservation { get; set; }
        public int RaisonAnnulationDossier { get; set; }
        public int IdAssurance { get; set; }
        public int IdVoyage { get; set; }
        [ForeignKey("IdAssurance")]
        public virtual Assurance Assurance { get; set; }
        [ForeignKey("IdVoyage")]
        public virtual Voyage Voyage { get; set; }

    }

}

