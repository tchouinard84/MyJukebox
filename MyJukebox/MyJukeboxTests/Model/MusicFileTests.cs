using System;
using Id3;
using MyJukebox.Model;
using NUnit.Framework;
using PAGeneratorTests;

namespace MyJukeboxTests.Model
{
    [TestFixture]
    public class MusicFileTests
    {
        private const string Title = "title";
        private const string Artist = "artist";
        private const string Album = "album";
        private const string Genre = "genre";

        private const int Year = 1991;

        private static readonly DateTime? NullYear;
        private static readonly int? NullYear_int;

        [Test] public void EnsureNullYearWhenId3TagYearIsNull()
        {
            var tag = Id3Tag(NullYear);
            var musicFile = MusicFile.ValueOf(tag);
            TestUtil.AssertAreEqual(musicFile, ExpectedMusicFile(NullYear_int));
        }

        [Test] public void EnsureMusicFileReturnedWhenGivenId3Tag()
        {
            var tag = Id3Tag();

            var musicFile = MusicFile.ValueOf(tag);
            TestUtil.AssertAreEqual(musicFile, ExpectedMusicFile());
        }

        private MusicFile ExpectedMusicFile()
        {
            return ExpectedMusicFile(Year);
        }

        private MusicFile ExpectedMusicFile(int? year)
        {
            return new MusicFile
            {
                Title = Title,
                Artist = Artist,
                Album = Album,
                Year = year,
                Genre = Genre
            };
        }

        private static Id3Tag Id3Tag()
        {
            return Id3Tag(new DateTime(Year,1,1,0,0,0));
        }

        private static Id3Tag Id3Tag(DateTime? year)
        {
            return new Id3Tag
            {
                Title = { Value = Title },
                Artists = { Value = Artist },
                Album = { Value = Album },
                Year = { AsDateTime = year },
                Genre = { Value = Genre}
            };
        }
    }
}
