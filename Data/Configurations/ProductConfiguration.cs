using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.Providers)
            .WithMany(pr => pr.Products)
            .UsingEntity(
            j => j.ToTable("Providings"));//Table d'association;


            builder.Property(p => p.Description).HasMaxLength(200).IsRequired(false);
            //One To Many
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            ////Inheritance
            builder.HasDiscriminator<int>("IsBiological")
             .HasValue<Product>(0)
             .HasValue<Biological>(1)
             .HasValue<Chemical>(2);
        }
    }
}
