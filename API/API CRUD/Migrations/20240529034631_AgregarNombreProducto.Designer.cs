﻿// <auto-generated />
using API_CRUD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_CRUD.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240529034631_AgregarNombreProducto")]
    partial class AgregarNombreProducto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("API_CRUD.Categoria", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("estatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("API_CRUD.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("estatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("telefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("idCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("API_CRUD.Pedido", b =>
                {
                    b.Property<int>("idPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("estatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idPedido");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("API_CRUD.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("estatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("idProducto");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("API_CRUD.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("contrasena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("estatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("rol")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("DetallePedido", b =>
                {
                    b.Property<int>("idDetallePedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("estatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombreProducto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("precioUnitario")
                        .HasColumnType("TEXT");

                    b.HasKey("idDetallePedido");

                    b.ToTable("DetallePedido");
                });
#pragma warning restore 612, 618
        }
    }
}
