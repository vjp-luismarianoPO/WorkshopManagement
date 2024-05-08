using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkshopManagement.Infrastructure.Data.Configurations
{
	public class ClientConfiguration : IEntityTypeConfiguration<Client>
	{
		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Clients__3214EC075B63F524");

			builder.Property(e => e.Id)
				.HasMaxLength(20)
				.IsUnicode(false);
			builder.Property(e => e.CarModel)
				.HasMaxLength(100)
				.IsUnicode(false);
			builder.Property(e => e.Email)
				.HasMaxLength(100)
				.IsUnicode(false);
			builder.Property(e => e.Name)
				.HasMaxLength(100)
				.IsUnicode(false);
			builder.Property(e => e.Phone)
				.HasMaxLength(20)
				.IsUnicode(false);

			builder.HasOne(d => d.Accident).WithMany(p => p.Clients)
				.HasForeignKey(d => d.AccidentId)
				.HasConstraintName("FK_Clients_Accidents");

			builder.HasOne(d => d.Company).WithMany(p => p.Clients)
				.HasForeignKey(d => d.CompanyId)
				.HasConstraintName("FK_Clients_Companies");
		}
	}
}
