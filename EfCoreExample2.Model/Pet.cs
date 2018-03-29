// <copyright file="Pet.cs" company="None">
// Copyright (c) None. All rights reserved.
// </copyright>

namespace EfCoreExample2.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// This describes a table row.
    /// </summary>
    [Table("Pet")]
    public class Pet
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}