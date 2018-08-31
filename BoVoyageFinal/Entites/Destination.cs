using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoVoyageFinal.Entites

{
    [Table("Destinations")]
    public class Destination
    {
        public string Continent { get; set; }
        public string Pays { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
        [Key]
        public int Id { get; set; }



    }

}

