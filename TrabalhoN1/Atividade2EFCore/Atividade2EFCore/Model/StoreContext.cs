using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Atividade2EFCore.Model
{
    /// <summary>
    /// Install the following nuget packages in my project:
    ///     Microsoft.Extensions.Configuration
    ///     Microsoft.Extensions.Configuration.FileExtensions
    ///     Microsoft.Extensions.Configuration.Json
    /// </summary>
    class StoreContext : DbContext
    {
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ContaCorrente> ContasCorrente { get; set; }
        public DbSet<ContaPoupanca> ContasPoupanca { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }

        private static IConfigurationRoot _configuration;

        public StoreContext()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _configuration = builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cnn = (_configuration.GetConnectionString("cnn"));
            optionsBuilder.UseSqlite(cnn);
        }

    }
}
