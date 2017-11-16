using System.Data.Entity;
using UMC.Model.Entity;

namespace UMC.Data
{
    public class HLDSDbContext : DbContext
    {
        public HLDSDbContext() : base("HLDS")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer<HLDSDbContext>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<UMCDbContext, Configuration>());
        }

        public DbSet<Shift> Shifts { set; get; }
        public DbSet<Line> Lines { set; get; }
        public DbSet<Station> Stations { set; get; }
        public DbSet<Quantity> Quantities { set; get; }
        public DbSet<LineStation> LineStations { set; get; }
        public DbSet<TimeSetting> TimeSettings { set; get; }
        public DbSet<TimeDaily> TimeDailies { set; get; }

        public static HLDSDbContext Create()
        {
            return new HLDSDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}