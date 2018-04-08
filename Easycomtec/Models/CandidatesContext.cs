using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Easycomtec.Models
{
    public class CandidatesContext : DbContext
    {
        public CandidatesContext() : base("DefaultConnection")
        {
            Database.SetInitializer<CandidatesContext>(new CandidatesSeed());
        }

        public DbSet<Candidates> Candidates { get; set; }
        public DbSet<OccupationArea> OccupationArea { get; set; }
        public DbSet<InformationBank> InformationBank { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));

            modelBuilder.Entity<Knowledge>()
                .HasKey(x => x.KnowledgeID)
                .HasRequired(t => t.Canditates)
                .WithRequiredDependent(p => p.Knowledge);

            modelBuilder.Entity<OccupationArea>()
                .HasKey(x => x.OccupationAreaID)
                .HasRequired(t => t.Canditates)
                .WithRequiredDependent(p => p.OccupationArea);

            modelBuilder.Entity<InformationBank>()
                .HasKey(x => x.InformationBankID)
                .HasRequired(t => t.Canditates)
                .WithRequiredDependent(p => p.InformationBank);


        }
    }
}