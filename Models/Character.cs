using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Step 3: Create the data model
namespace FinalProject.Models
{
    public class Character
    {
        public int ProfessorId { get; set; } // Primary Key
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [Range(1, 10)]
        public int Strength { get; set; }
        [Required]
        [Range(1, 10)]
        public int Dexterity { get; set; }
        [Required]
        [Range(1, 10)]
        public int Intelligence { get; set; }
        [Required]
        [Range(1, 10)]
        public int Charisma { get; set; }
        public Weapon Weapon { get; set; }
    }
}