namespace BoVoyageFinal.Entites
{
    public class Assurance
    {
        //[ForeignKey("Id")]
        public int Id { get; set; }

        public int Montant { get; set; }
        public int Annulation { get; set; }
    }
}
