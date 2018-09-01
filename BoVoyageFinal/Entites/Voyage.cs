using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BoVoyageFinal.Entites
{
    public class Voyage
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public int PlacesDisponibles { get; set; }
        public int PrixParPersonne { get; set; }

        [ForeignKey("IdAgenceVoyage")]
        public int IdAgenceVoyage { get; set; }

        [ForeignKey("IdDestination")]
        public int IdDestination { get; set; }

        //public virtual ICollection<Destination> destinations { get; set; }

    }

}

