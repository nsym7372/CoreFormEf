using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace WindowsFormsApp1.Models
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=8081;User Id=postgres;Password=mypassword;Database=Sample;");
            //optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["Sample"].ConnectionString);
        }

        // ↓Web
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<SampleContext>(o => o.UseNpgsql("Server=localhost;Port=8081;User Id=postgres;Password=mypassword;Database=SampleDb;"));
        //}

        public DbSet<GamingDevice> GamingDevices { get; set; }
    }
}
