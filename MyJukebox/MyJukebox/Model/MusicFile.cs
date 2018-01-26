using Id3;
using System;
using System.Collections.Generic;

namespace MyJukebox.Model
{
    public class MusicFile
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int? Year { get; set; }
        public string Genre { get; set; }
        public TimeSpan Length { get; set; }
        public int? Rating { get; set; }
        public List<string> Tags { get; set; }
        public string FileName { get; set; }
        public string FolderPath { get; set; }
        public decimal? FileSize { get; set; }

        public static MusicFile ValueOf(Id3Tag tag)
        {
            return new MusicFile
            {
                Title = tag.Title.Value,
                Artist = tag.Artists.Value,
                Album = tag.Album.Value,
                Year = DetermineYear(tag),
                Genre = tag.Genre.Value
            };
        }

        private static int? DetermineYear(Id3Tag tag)
        {
            if (!tag.Year.AsDateTime.HasValue) { return null; }
            return tag.Year.AsDateTime.Value.Year;
        }
    }
}
