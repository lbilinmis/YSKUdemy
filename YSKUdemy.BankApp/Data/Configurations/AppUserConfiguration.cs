using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YSKUdemy.BankApp.Data.Entities;

namespace YSKUdemy.BankApp.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.SurName).HasMaxLength(50);
            builder.Property(x => x.SurName).IsRequired();

            builder.HasMany(x => x.Accounts).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
        }
    }
}
