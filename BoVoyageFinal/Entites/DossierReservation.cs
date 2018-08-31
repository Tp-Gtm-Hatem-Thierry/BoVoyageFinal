namespace BoVoyageFinal.Entites
{
    public class DossierReservation
    {
        public int NumeroUnique { get; set; }
        public string NumeroCarteBancaire { get; set; }
        public int PrixParPersonne { get; set; }
        public int PrixTotal { get; set; }
        public int EtatDossierReservation { get; set; }
        public int RaisonAnnulationDossier { get; set; }
        public int IdAssurance { get; set; }
        public int IdVoyage { get; set; }

    }

}

