using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Shared.Models;

namespace WeatherApp.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {

        }

        

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<WeatherData> WeatherData { get; set; }
    }
}
