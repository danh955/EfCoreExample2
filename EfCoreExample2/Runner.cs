// <copyright file="Runner.cs" company="None">
// Copyright (c) None. All rights reserved.
// </copyright>

namespace EfCoreExample2
{
    using System;
    using System.Linq;
    using EfCoreExample2.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Running the application class.
    /// </summary>
    public class Runner
    {
        private PetContext petContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="Runner"/> class.
        /// </summary>
        /// <param name="petContext">Pet database context.</param>
        public Runner(PetContext petContext)
        {
            this.petContext = petContext;
        }

        /// <summary>
        /// Run the application.
        /// </summary>
        public void Run()
        {
            PetContext db = this.petContext;

            // Migrate the database to a newer version if any.
            db.Database.Migrate();

            // Get a pet.
            string[] listOfNames = { "Cat", "Dog", "Fish", "Bird" };
            string petName = listOfNames[db.Pets.Count() % listOfNames.Length];
            Console.WriteLine($"Adding {petName}");

            // Add a pet.
            Pet onePet = new Pet { Name = petName };
            db.Add(onePet);
            db.SaveChanges();

            // List the pets.
            db.Pets
                .Select(pet => pet)
                .ToList()
                .ForEach(p => { Console.WriteLine($"ID={p.Id}, Name={p.Name}"); });
        }
    }
}