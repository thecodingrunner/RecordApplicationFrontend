using System.ComponentModel.DataAnnotations;

namespace RecordApplication.Entities
{
    public class Album
    {
        public Album(string albumName, int artistId, string artistName, int releaseYear, int units, Genre genre, string description, string coverUrl, string spotifyUrl)
        {
            AlbumName = albumName;
            ArtistId = artistId;
            ArtistName = artistName;
            ReleaseYear = releaseYear;
            Units = units;
            Genre = genre;
            Description = description;
            CoverUrl = coverUrl;
            SpotifyUrl = spotifyUrl;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string AlbumName { get; set; }
        public int ArtistId { get; set; }

        [Required]
        [MaxLength(255)]
        public string ArtistName { get; set; }

        [Required]
        [Range(1500, 2050)]
        public int ReleaseYear { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Units { get; set; }

        [Required]
        [MaxLength(255)]
        public Genre Genre { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public string CoverUrl { get; set; } = "";

        [Required]
        public string SpotifyUrl { get; set; } = "";
	}
}
