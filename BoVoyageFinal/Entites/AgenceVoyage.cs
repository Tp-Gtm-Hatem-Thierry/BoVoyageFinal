using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoVoyageFinal.Entites
{
    [Table ("AgencesVoyages")]
    public class AgenceVoyage
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }

}

