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
            ///ConnectionString bilgisini ayar yönetiminden alarak kullanmak, uygulamanın farklı ortamlarda (geliştirme, test, üretim) çalışırken farklı veritabanlarına bağlanmasını kolaylaştırır. Bu sayede kodun içinde bağlantı dizesi hard-coded olarak bulunmaz ve güvenlik açısından da daha iyi bir yaklaşım olur.
            string? connectionString = AyarYonetim.DbAyar.GetConnectionString("LokantaConnection");
            optionsBuilder.UseSqlServer(connectionString);

            ///ConnectionString bilgisini doğrudan kod içinde tanımlamak, hızlı bir şekilde veritabanına bağlanmak için kullanılabilir, ancak bu yöntem genellikle önerilmez çünkü bağlantı dizesi kod içinde hard-coded olarak bulunur ve güvenlik riskleri oluşturabilir. Ayrıca, farklı ortamlarda farklı veritabanlarına bağlanmak gerektiğinde esneklik sağlamaz.
            ///optionsBuilder.UseSqlServer(@"Server=LAB708-PC;Database=Lokanta;Trusted_Connection=True;TrustServerCertificate=True");
         
        }


    }
}
