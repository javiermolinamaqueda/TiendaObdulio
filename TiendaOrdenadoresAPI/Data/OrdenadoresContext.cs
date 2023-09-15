﻿using Microsoft.EntityFrameworkCore;
using TiendaOrdenadoresAPI.Models;

namespace TiendaOrdenadoresAPI.Data
{
    public class OrdenadoresContext : DbContext
    {
        public OrdenadoresContext (DbContextOptions<OrdenadoresContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Factura> Facturas { get; set; } = default!;
        public DbSet<Pedido> Pedidos { get; set; } = default!;
        public DbSet<Ordenador> Ordenadores { get; set; } = default!;
        public DbSet<Componente> Componentes { get; set; } = default!;
    }
}
