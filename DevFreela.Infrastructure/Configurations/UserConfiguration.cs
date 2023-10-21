using DevFreela.Core.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
            .HasKey(p => p.Id);

            builder
             .HasMany(u => u.Skills)
             .WithOne()
             .HasForeignKey(u => u.IdSkill)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
