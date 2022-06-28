using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(f => new { f.ClientFk,f.ProductFk, f.DateAchat });
            builder.HasOne<Product>(f => f.Product).WithMany(p => p.Factures).HasForeignKey(f => f.ProductFk);
            builder.HasOne<Client>(f => f.Client).WithMany(c => c.Factures).HasForeignKey(f => f.ClientFk);
            



        }
    }
}
