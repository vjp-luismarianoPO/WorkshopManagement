using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkshopManagement.Infrastructure.Data.Configurations
{
	public class CompanyConfiguration : IEntityTypeConfiguration<Company>
	{

		public void Configure(EntityTypeBuilder<Company> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Companie__3214EC07140B1260");

			builder.Property(e => e.Name)
				.HasMaxLength(100)
				.IsUnicode(false);
		}
	}
}
