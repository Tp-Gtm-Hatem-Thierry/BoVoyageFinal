using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BoVoyageFinal.Entites;

namespace BoVoyageFinal.Dal
{
    public class Contexte : DbContext
    {
        public DbSet<DossierReservation> DossiersReservations { get; set; }

        public DbSet<AgenceVoyage> AgencesVoyages { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<Voyage> Voyages { get; set; }

        public DbSet<Assurance> Assurances { get; set; }
    }
}
