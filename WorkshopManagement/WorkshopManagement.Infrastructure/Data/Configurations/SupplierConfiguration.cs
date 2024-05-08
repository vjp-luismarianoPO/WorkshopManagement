using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkshopManagement.Infrastructure.Data.Configurations
{
	public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
	{
		public void Configure(EntityTypeBuilder<Supplier> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Supplier__3214EC077CDEEE8D");

			builder.Property(e => e.Name)
				.HasMaxLength(100)
				.IsUnicode(false);
			builder.Property(e => e.Phone)
				.HasMaxLength(20)
				.IsUnicode(false);
		}
	}
}
