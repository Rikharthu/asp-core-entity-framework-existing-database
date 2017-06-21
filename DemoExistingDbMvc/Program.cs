using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace DemoExistingDbMvc
{
    /* Run in Package Manager Console:
        Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=ActorDb;Trusted_Connection=True;"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
       To generate models and DbContext for existing database (Database-First approach) in ~\Models directory
       It uses a specified connection to locate an existing database and create an entity class and derive the context based class on
       the schema of that database.
       In other words we reverse-engineer our model
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
