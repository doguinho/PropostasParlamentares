using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using PropostasParlamentares.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;


namespace PropostasParlamentares.Context
{
    public class DataBaseContext : DbContext
    {

        public DbSet<Votante> Votante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseOracle(config.GetConnectionString(@"User Id=fiap;Password=fiapbuzz;Data Source=localhost:5500/XE"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}