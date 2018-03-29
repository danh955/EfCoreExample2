// <copyright file="PetContext.cs" company="None">
// Copyright (c) None. All rights reserved.
// </copyright>

namespace EfCoreExample2.Model
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// This class is use to access the database.
    /// </summary>
    public class PetContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetContext"/> class.
        /// </summary>
        /// <param name="options">Database context options.</param>
        public PetContext(DbContextOptions options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the pets table.
        /// </summary>
        public DbSet<Pet> Pets { get; set; }
    }
}