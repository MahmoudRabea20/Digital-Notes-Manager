
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Login.Model
{
    [Index("Username", IsUnique = true)]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        // One To Many Relation with Note
        public virtual ICollection<Note> Notes { get; set; } = new HashSet<Note>();
    }
}
