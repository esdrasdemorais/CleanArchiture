using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System.IO;

namespace CleanArchiture
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
	    var configuration = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile(
		    path: "appsettings.json",
		    optional: false,
		    reloadOnChange: true)
		.AddJsonFile(
		    path: $"appsettings.{Environment.GetEnvironmentVariable("")}.json",
		    optional: true,
		    reloadOnChange: true)
		.Build();

	    Log.Logger = new LoggerConfiguration()
		.ReadFrom.Configuration(configuration)
		.Enrich.FromLogContext()
		.WriteTo.Console()
		.CreateLogger();

            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
	    	.UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.UseStartup<Startup>())
		    .UseDefaultServiceProvider(
			(context, options) =>
			    {
			    	options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
				options.ValidateOnBuild = true;
                	    }
			);
    }
}
