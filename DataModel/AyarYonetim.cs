using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.Configuration.Json;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// Bağlantı cümleciği gibi ayarların yönetimi için kullanılan statik bir sınıf.
    /// DbContext nesnesi oluşturulurken bu sınıfın DbAyar özelliği kullanılarak appsettings.json dosyasındaki ayarlar alınır.
    /// Böylece, uygulamanın farklı bölümlerinde aynı ayarları kullanmak ve merkezi bir yerden yönetmek mümkün olur.
    /// DbContext her oluşturulduğunda json dosyasını yeniden okumayız, çünkü DbAyar özelliği statik olarak tanımlanmıştır ve sınıf ilk kez kullanıldığında bir kez yüklenir. Bu sayede performans açısından da avantaj sağlanır.
    /// </summary>
    public static class AyarYonetim
    {
        public static IConfiguration DbAyar { get; }

        static AyarYonetim() 
        {
            DbAyar = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();     

        }
    }
}
