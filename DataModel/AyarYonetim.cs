using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public static class AyarYonetim
    {
        public static IConfiguration DbAyar { get; }

        static AyarYonetim() 
        {
            var builder = new ConfigurationBuilder();           
            //DbAyar = builder.AddJsonFile("appsettings.json").Build();

        }
    }
}
