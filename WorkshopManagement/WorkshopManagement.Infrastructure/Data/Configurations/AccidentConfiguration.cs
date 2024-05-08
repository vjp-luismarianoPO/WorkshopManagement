using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkshopManagement.Infrastructure.Data.Configurations
{
	public class AccidentConfiguration : IEntityTypeConfiguration<Accident>
	{
		public void Configure(EntityTypeBuilder<Accident> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Accident__3214EC077AE9AD2F");

			builder.Property(e => e.ClientId)
				.HasMaxLength(20)
				.IsUnicode(false);
			builder.Property(e => e.Type)
				.HasMaxLength(100)
				.IsUnicode(false);

			builder.HasOne(d => d.Client).WithMany(p => p.Accidents)
				.HasForeignKey(d => d.ClientId)
				.HasConstraintName("FK_Accidents_Clients");

			builder.HasOne(d => d.Company).WithMany(p => p.Accidents)
				.HasForeignKey(d => d.CompanyId)
				.HasConstraintName("FK_Accidents_Companies");

			builder.HasOne(d => d.Supplier).WithMany(p => p.Accidents)
				.HasForeignKey(d => d.SupplierId)
				.HasConstraintName("FK_Accidents_Suppliers");
		}
	}
}
