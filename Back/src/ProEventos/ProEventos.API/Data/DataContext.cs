using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Data
{
    public class DataContext: DbContext
    {

        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options) { }
    }
}
