﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Configurations
{
    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
           builder.ToTable("OderDetails");

           builder.HasKey(od=>new {od.OrderId,od.ProductId});

           builder.HasOne(o=>o.Order).WithMany(od=>od.OrderDetails).HasForeignKey(x=> x.OrderId);

           builder.HasOne(o => o.Product).WithMany(od => od.OrderDetails).HasForeignKey(x => x.ProductId);


        }
    }
}
