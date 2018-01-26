using Id3;
using MyJukebox.Model;
using System.ComponentModel;

namespace MyJukebox.ViewModel
{
    public class MusicFileViewModel : INotifyPropertyChanged
    {
        private string _title;
        public string Title {
            get => _title;
            set {
                if (_title == value) { return; }
                _title = value;
                NotifyPropertyChanged("Title");
            }
        }
        private string _artist;
        public string Artist {
            get => _artist;
            set {
                if (_artist == value) { return; }
                _artist = value;
                NotifyPropertyChanged("Artist");
            }
        }
        private string _album;
        public string Album {
            get => _album;
            set {
                if (_album == value) { return; }
                _album = value;
                NotifyPropertyChanged("Album");
            }
        }
        private int? _year;
        public int? Year {
            get => _year;
            set {
                if (_year == value) { return; }
                _year = value;
                NotifyPropertyChanged("Year");
            }
        }
        private string _genre;
        public string Genre {
            get => _genre;
            set {
                if (_genre == value) { return; }
                _genre = value;
                NotifyPropertyChanged("Genre");
            }
        }

        public void Open(string file)
        {
            using (var mp3 = new Mp3File(file))
            {
                var tag = mp3.GetTag(Id3TagFamily.FileStartTag);

                var mp3File = MusicFile.ValueOf(tag);
                Title = mp3File.Title;
                Artist = mp3File.Artist;
                Album = mp3File.Album;
                Year = mp3File.Year;
                Genre = mp3File.Genre;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
