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
    public static class AyarYonetim
    {
        public static IConfiguration DbAyar { get; }

        static AyarYonetim() 
        {
            DbAyar = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();           
            //DbAyar = builder.AddJsonFile("appsettings.json").Build();

        }
    }
}
