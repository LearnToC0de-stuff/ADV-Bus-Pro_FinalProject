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
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon {WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5}
                        
                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    }
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    },
                    new Character
                    {
                        FirstName = "Kareem",
                        LastName = "Dana",
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Charisma = 1,

                        Weapon = new Weapon { WeaponName = "CIDM 3312", Damage = "3d12", Reach = 5 }

                    }
                );
                context.SaveChanges();
            }
        }

    }
}