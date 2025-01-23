using System.ComponentModel.DataAnnotations;

namespace RecordApplication.Entities
{
    public class Artist
    {
        public Artist(string name)
        {
            Name = name;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
