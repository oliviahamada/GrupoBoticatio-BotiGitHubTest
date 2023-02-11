using System.Data.Entity.ModelConfiguration;

namespace GrupoBoticatio.Entities
{
    public class RepositoriesItemsDetailsMap : EntityTypeConfiguration<RepositoriesItemsDetails>
    {
        public RepositoriesItemsDetailsMap()
        {
            this.ToTable("RepositoriesItemsDetails");
            this.HasKey(x => x.Language);
            this.HasKey(x => x.RepositoryId);

            this.Property(x => x.Id).HasColumnName("Id").IsRequired();
            this.Property(x => x.RepositoryId).HasColumnName("RepositoryId").IsRequired();
            this.Property(x => x.Language).HasColumnName("Language").IsRequired().HasMaxLength(255);
            this.Property(x => x.FullName).HasColumnName("FullName").IsRequired().HasMaxLength(255);
            this.Property(x => x.HtmlUrl).HasColumnName("HtmlUrl").IsRequired().HasMaxLength(255);
            this.Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(8000); ;
            this.Property(x => x.IsPrivate).HasColumnName("IsPrivate").IsRequired();
            this.Property(x => x.StargazersCount).HasColumnName("StargazersCount").IsRequired();
            this.Property(x => x.Page).HasColumnName("Page");
            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}