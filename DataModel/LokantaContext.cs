using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataModel
{
    /// <summary>
    /// Entity bildirimleri bu sınıf içinde yapılır. 
    /// DbSet<T> türünde tanımlanan özellikler, veritabanında tablolar olarak karşılık bulur.
    /// Bu sınıf, Entity Framework Core tarafından veritabanı işlemleri için kullanılır.
    /// Bu sınıf içindeki her DbSet<T> bildirimi veri tabanındaki bir tabloya karşılık gelir
    /// </summary>
    public class LokantaContext:DbContext
    {
       public DbSet<Kullanici> Kullanici { get; set; }


        ///Veri tabanı bağlantı işlemleri için OnConfiguring metodu kullanılır. Bu metod içinde UseSqlServer gibi bir yöntemle veritabanı bağlantı dizesi sağlanır.
        ///
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {    
            //string connectionString = ConfigurationManager.ConnectionStrings["LokantaConnection"].ConnectionString;
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            //string connectionString2 = AyarYonetim.DbAyar.GetConnectionString("LokantaConnection");
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseSqlServer(@"Server=LAB708-PC;Database=Lokanta;Trusted_Connection=True;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
