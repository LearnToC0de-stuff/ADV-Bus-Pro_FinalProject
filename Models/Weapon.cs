using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Weapon
    {
        public int WeaponId { get; set; } // Primary Key
        [Required]
        public string WeaponName { get; set; }
        [Required]
        public string Damage { get; set; }
        [Required]
        [Range(5, 10)]
        public int Reach { get; set; }

        public int CharacterId {get; set;}
        public List<Character> Characters { get; set; }
    }
}