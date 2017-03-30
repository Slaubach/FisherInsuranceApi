using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FisherInsuranceAPI.Data;

namespace FisherInsuranceAPI.Migrations
{
    [DbContext(typeof(FisherContext))]
    [Migration("20170305224558_Update-quotes")]
    partial class Updatequotes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("FisherInsuranceAPI.Models.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("LossAmount");

                    b.Property<DateTime>("LossDate");

                    b.Property<string>("PolicyNumber");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("FisherInsuranceAPI.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpireDate");

                    b.Property<decimal>("Price");

                    b.Property<string>("Product");

                    b.HasKey("Id");

                    b.ToTable("Quotess");
                });
        }
    }
}
