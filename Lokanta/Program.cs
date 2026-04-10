using Islem;
using Microsoft.Extensions.DependencyInjection;

namespace Lokanta
{
    internal static class Program
    {
        public static IServiceProvider serviceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ///DI container oluþuturup servisleri ekleyebiliriz
            ///Mesela siparis iþlemelerini temisl eden bir interface oluþturup 
            ///onun implementasyonunu yaparak siparis iþlemlerini gerçekleþtirebiliriz
            ///Servis ile kullanacaðýmýz tüm formlarý tek bir yerden yönetebiliriz
            ///servis ile kullanýlacak tüm nesneleri tek bir yerden yönetebiliriz
            ///Eðer bir formda bir nesneye ihtiyaç duyarsak servis üzerinden o nesneyi alabiliriz
            ///
            ServiceCollection services= new ServiceCollection();
            services.AddTransient<AnaForm>();
            services.AddTransient<MasaSiparis>();
            services.AddTransient<MasaSiparisAlma>();
            services.AddTransient<MasaSiparisIslem>();
            serviceProvider = services.BuildServiceProvider();
            ///DI containerdaki servisleri servisprovider üzerinden alarak kullanabiliriz

            ///Transient, Scpoped, Singleton gibi yaþam döngüsü yönetimi seçenekleri vardýr
            ///Transient: Her istekte yeni bir nesne oluþturur
            ///Scoped: Ayný scope içinde ayný nesneyi kullanýr
            ///Singleton: Uygulama boyunca tek bir nesne kullanýr

            serviceProvider.GetService<AnaForm>();

            //Application.Run(new AnaForm());
            Application.Run(serviceProvider.GetService<AnaForm>());


        }
    }
}