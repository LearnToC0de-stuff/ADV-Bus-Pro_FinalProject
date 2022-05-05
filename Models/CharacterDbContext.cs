using Microsoft.EntityFrameworkCore;

// Step 3: Create the Data Model
namespace FinalProject.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options)
            : base(options)
        {
        }
        public DbSet<Character> Character { get; set; }
        public DbSet<Weapon> Weapon { get; set; }
    }
}