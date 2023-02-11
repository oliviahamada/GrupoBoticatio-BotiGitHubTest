using System.Data.Entity;
using GrupoBoticatio.Entities;

namespace GrupoBoticatio.Context
{

    public class ManagerContext : DbContext
    {
        public ManagerContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            //Configuration.AutoDetectChangesEnabled = false;
            Database.CommandTimeout = 180;

#if DEBUG
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
#endif
        }

        public DbSet<RepositoriesLanguages> RepositoriesLanguages { get; set; }
        public DbSet<RepositoriesItemsDetails> RepositoriesItemsDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new RepositoriesLanguagesMap());
            modelBuilder.Configurations.Add(new RepositoriesItemsDetailsMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}