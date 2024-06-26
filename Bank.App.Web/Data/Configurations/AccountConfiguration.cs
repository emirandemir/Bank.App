﻿using Bank.App.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank.App.Web.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.AccountNumber).IsRequired();
            builder.Property(x => x.Balance).HasColumnType("decimal(18,4)");
            builder.Property(x=>x.Balance).IsRequired();
        }
    }
}
