using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FisherInsuranceAPI.Data;

namespace FisherInsuranceAPI.Migrations
{
    [DbContext(typeof(FisherContext))]
    [Migration("20170228013505_init")]
    partial class init
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
        }
    }
}
