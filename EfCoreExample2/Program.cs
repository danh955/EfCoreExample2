// <copyright file="Program.cs" company="None">
// Copyright (c) None. All rights reserved.
// </copyright>

namespace EfCoreExample2
{
    using EfCoreExample2.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Main program class.
    /// </summary>
    internal class Program : IDesignTimeDbContextFactory<PetContext>
    {
        private const string ConnectionString = "Data Source=Pet.db";

        /// <summary>
        /// IDesignTimeDbContextFactory create DB context.
        /// This is for the add-migration command.
        /// </summary>
        /// <param name="args">Command line arguments. (not used)</param>
        /// <returns>Pet context.</returns>
        public PetContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<PetContext> builder = new DbContextOptionsBuilder<PetContext>()
               .UseSqlite(ConnectionString);

            return new PetContext(builder.Options);
        }

        /// <summary>
        /// Get the service providers.
        /// </summary>
        /// <returns>Service provider object.</returns>
        private static ServiceProvider GetServiceProviders()
        {
            ServiceCollection services = new ServiceCollection();
            services
                .AddTransient<Runner>()
                .AddDbContextPool<PetContext>(builder => { builder.UseSqlite(ConnectionString); });

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }

        /// <summary>
        /// Program starts here.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        private static void Main(string[] args)
        {
            using (ServiceProvider serviceProvider = GetServiceProviders())
            {
                Runner runner = serviceProvider.GetRequiredService<Runner>();
                runner.Run();
            }
        }
    }
}