using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Domain.Model;
using System.Data.SqlClient;

namespace PrimeiraAPI.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "localhost,1433",
                InitialCatalog = "master",
                UserID = "sa",
                Password = "#Nanica21",
                TrustServerCertificate = true // Ignorar a validação do certificado
            };

            optionsBuilder.UseSqlServer(connectionStringBuilder.ToString());
        }
    }
}
