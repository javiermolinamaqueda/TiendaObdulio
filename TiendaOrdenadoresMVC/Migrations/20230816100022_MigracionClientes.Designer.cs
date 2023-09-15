﻿// <auto-generated />
using MVC_ComponentesCodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_ComponentesCodeFirst.Migrations
{
    [DbContext(typeof(OrdenadoresContext))]
    [Migration("20230816100022_MigracionClientes")]
    partial class MigracionClientes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreditCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Componente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calor")
                        .HasColumnType("int");

                    b.Property<int>("Cores")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("Megas")
                        .HasColumnType("bigint");

                    b.Property<int>("OrdenadorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TipoComponente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdenadorId");

                    b.ToTable("Componentes");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Ordenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Ordenadores");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("FacturaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FacturaId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Componente", b =>
                {
                    b.HasOne("MVC_ComponentesCodeFirst.Models.Ordenador", "Ordenador")
                        .WithMany("Componentes")
                        .HasForeignKey("OrdenadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ordenador");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Ordenador", b =>
                {
                    b.HasOne("MVC_ComponentesCodeFirst.Models.Pedido", "Pedido")
                        .WithMany("Ordenadores")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Pedido", b =>
                {
                    b.HasOne("MVC_ComponentesCodeFirst.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_ComponentesCodeFirst.Models.Factura", "Factura")
                        .WithMany("Pedidos")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Factura");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Factura", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Ordenador", b =>
                {
                    b.Navigation("Componentes");
                });

            modelBuilder.Entity("MVC_ComponentesCodeFirst.Models.Pedido", b =>
                {
                    b.Navigation("Ordenadores");
                });
#pragma warning restore 612, 618
        }
    }
}
