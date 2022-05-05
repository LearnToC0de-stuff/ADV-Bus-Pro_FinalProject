using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

// Step 7: Seed Data Class
namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CharacterContext(serviceProvider.GetRequiredService<DbContextOptions<CharacterContext>>()))
            {
                if (context.Character.Any())
                {
                    return;
                }

                context.Character.AddRange(
                    new Character
                    {
                        FirstName = "Naruto",
                        LastName = "Uzumaki",
                        Strength = 7,
                        Dexterity = 6,
                        Intelligence = 3,
                        Charisma = 7,

                        Weapon = new Weapon { WeaponName = "Knife", Damage = "1d12", Reach = 5 }
                        
                    },
                    new Character
                    {
                        FirstName = "Thor",
                        LastName = "Odinson",
                        Strength = 10,
                        Dexterity = 4,
                        Intelligence = 3,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Hammer", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Ezio",
                        LastName = "Auditore",
                        Strength = 5,
                        Dexterity = 8,
                        Intelligence = 6,
                        Charisma = 7,

                        Weapon = new Weapon { WeaponName = "Knife", Damage = "1d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Booker",
                        LastName = "Dewitt",
                        Strength = 5,
                        Dexterity = 5,
                        Intelligence = 5,
                        Charisma = 4,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Cloud",
                        LastName = "Strife",
                        Strength = 7,
                        Dexterity = 6,
                        Intelligence = 5,
                        Charisma = 2,

                        Weapon = new Weapon { WeaponName = "Sword", Damage = "2d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Agent",
                        LastName = "47",
                        Strength = 6,
                        Dexterity = 6,
                        Intelligence = 7,
                        Charisma = 3,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Leon",
                        LastName = "Kennedy",
                        Strength = 5,
                        Dexterity = 6,
                        Intelligence = 5,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Luke",
                        LastName = "Skywalker",
                        Strength = 5,
                        Dexterity = 7,
                        Intelligence = 6,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Sword", Damage = "2d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Peter",
                        LastName = "Parker",
                        Strength = 9,
                        Dexterity = 8,
                        Intelligence = 7,
                        Charisma = 7,

                        Weapon = new Weapon { WeaponName = "Fists", Damage = "1d10", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Nathan",
                        LastName = "Drake",
                        Strength = 6,
                        Dexterity = 7,
                        Intelligence = 6,
                        Charisma = 7,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Son",
                        LastName = "Goku",
                        Strength = 9,
                        Dexterity = 6,
                        Intelligence = 2,
                        Charisma = 4,

                        Weapon = new Weapon { WeaponName = "Fists", Damage = "1d10", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Handsome",
                        LastName = "Jack",
                        Strength = 4,
                        Dexterity = 6,
                        Intelligence = 5,
                        Charisma = 8,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Miles",
                        LastName = "Morales",
                        Strength = 8,
                        Dexterity = 8,
                        Intelligence = 6,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Fists", Damage = "1d10", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Frank",
                        LastName = "West",
                        Strength = 6,
                        Dexterity = 5,
                        Intelligence = 4,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Solid",
                        LastName = "Snake",
                        Strength = 7,
                        Dexterity = 7,
                        Intelligence = 5,
                        Charisma = 4,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Noctis",
                        LastName = "Caliem",
                        Strength = 5,
                        Dexterity = 7,
                        Intelligence = 5,
                        Charisma = 4,

                        Weapon = new Weapon { WeaponName = "Sword", Damage = "2d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Katniss",
                        LastName = "Everdeen",
                        Strength = 4,
                        Dexterity = 8,
                        Intelligence = 5,
                        Charisma = 4,

                        Weapon = new Weapon { WeaponName = "Bow", Damage = "1d10", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Aloy",
                        LastName = "Nora",
                        Strength = 4,
                        Dexterity = 8,
                        Intelligence = 7,
                        Charisma = 6,

                        Weapon = new Weapon { WeaponName = "Bow", Damage = "1d10", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Peter",
                        LastName = "Quill",
                        Strength = 5,
                        Dexterity = 6,
                        Intelligence = 4,
                        Charisma = 7,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Liu",
                        LastName = "Kang",
                        Strength = 6,
                        Dexterity = 7,
                        Intelligence = 4,
                        Charisma = 4,

                        Weapon = new Weapon { WeaponName = "Fists", Damage = "1d10", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Johnny",
                        LastName = "Cage",
                        Strength = 6,
                        Dexterity = 6,
                        Intelligence = 5,
                        Charisma = 7,

                        Weapon = new Weapon { WeaponName = "Fists", Damage = "1d10", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Itachi",
                        LastName = "Uchiha",
                        Strength = 5,
                        Dexterity = 7,
                        Intelligence = 8,
                        Charisma = 2,

                        Weapon = new Weapon { WeaponName = "Knife", Damage = "1d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Sasuke",
                        LastName = "Uchiha",
                        Strength = 6,
                        Dexterity = 8,
                        Intelligence = 7,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Knife", Damage = "1d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Johnny",
                        LastName = "Gat",
                        Strength = 6,
                        Dexterity = 6,
                        Intelligence = 4,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Obi-Wan",
                        LastName = "Kenobi",
                        Strength = 6,
                        Dexterity = 7,
                        Intelligence = 6,
                        Charisma = 6,

                        Weapon = new Weapon { WeaponName = "Sword", Damage = "2d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Geralt",
                        LastName = "of Rivia",
                        Strength = 7,
                        Dexterity = 6,
                        Intelligence = 5,
                        Charisma = 4,

                        Weapon = new Weapon { WeaponName = "Sword", Damage = "2d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Lara",
                        LastName = "Croft",
                        Strength = 5,
                        Dexterity = 7,
                        Intelligence = 7,
                        Charisma = 6,

                        Weapon = new Weapon { WeaponName = "Bow", Damage = "1d10", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Jon",
                        LastName = "Snow",
                        Strength = 5,
                        Dexterity = 6,
                        Intelligence = 5,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Sword", Damage = "2d12", Reach = 5 }
                    },
                    new Character
                    {
                        FirstName = "Bruce",
                        LastName = "Wayne",
                        Strength = 7,
                        Dexterity = 7,
                        Intelligence = 8,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Fists", Damage = "1d10", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kal",
                        LastName = "Cestis",
                        Strength = 5,
                        Dexterity = 6,
                        Intelligence = 6,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Sword", Damage = "2d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Max",
                        LastName = "Payne",
                        Strength = 6,
                        Dexterity = 6,
                        Intelligence = 4,
                        Charisma = 3,

                        Weapon = new Weapon { WeaponName = "Gun", Damage = "1d8", Reach = 10 }

                    },
                    new Character
                    {
                        FirstName = "Frodo",
                        LastName = "Baggins",
                        Strength = 3,
                        Dexterity = 4,
                        Intelligence = 5,
                        Charisma = 5,

                        Weapon = new Weapon { WeaponName = "Knife", Damage = "1d12", Reach = 5 }

                    }
                );
                context.SaveChanges();
            }
        }

    }
}