using System.ComponentModel.DataAnnotations;

namespace RecordApplication.Entities
{
    public class AlbumInput
    {
        public AlbumInput(string albumName, string artistName, int releaseYear, int units, string genre, string description)
        {
            AlbumName = albumName;
            ArtistName = artistName;
            ReleaseYear = releaseYear;
            Units = units;
            Genre = genre;
            Description = description;
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string AlbumName { get; set; }
        [Required]
        [MaxLength(255)]
        public string ArtistName { get; set; }
        [Required]
        [Range(1500, 2500)]
        public int ReleaseYear { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Units { get; set; }
        [Required]
        [MaxLength(255)]
        public string Genre { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
