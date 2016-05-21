﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace gitdoko
{
    public class Program
    {
        public static void Main( string[] args )
        {
            var host = new WebHostBuilder();

            host.UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                ;

            host.Build().Run();
        }
    }
}
