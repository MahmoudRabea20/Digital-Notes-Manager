
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Login.Model
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ReminderDate { get; set; }

        // One To Many Relation with User

        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public override string ToString()
        {
            return $"NoteTitle { Title} ";
        }


    }
}
