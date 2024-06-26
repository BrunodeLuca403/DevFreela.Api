﻿using DevFreela.Core.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder.
                HasOne(p => p.Freelancer)
                .WithMany(p => p.FreelancerProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(p => p.Client)
                 .WithMany(p => p.OwnedProjects)
                 .HasForeignKey(p => p.IdCliente)
                 .OnDelete(DeleteBehavior.Restrict);

           
        }
    }
}
