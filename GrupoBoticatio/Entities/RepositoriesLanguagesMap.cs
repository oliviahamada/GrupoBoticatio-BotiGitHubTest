using System.Data.Entity.ModelConfiguration;

namespace GrupoBoticatio.Entities
{
    public class RepositoriesLanguagesMap : EntityTypeConfiguration<RepositoriesLanguages>
    {
        public RepositoriesLanguagesMap()
        {
            this.ToTable("RepositoriesLanguages");
            this.HasKey(x => x.Language);

            this.Property(x => x.Language).HasColumnName("Language").IsRequired().HasMaxLength(255); ;
            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}