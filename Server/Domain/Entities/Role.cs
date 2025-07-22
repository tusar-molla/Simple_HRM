using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Server.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        [Required]        
        public string Name { get; set; } = string.Empty;
    }
}
