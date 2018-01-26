using Id3;
using MyJukebox.Model;
using System.ComponentModel;

namespace MyJukebox.ViewModel
{
    public class MusicFileViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public void Open(string file)
        {
            using (var mp3 = new Mp3File(file))
            {
                var tag = mp3.GetTag(Id3TagFamily.FileStartTag);

                var mp3File = MusicFile.ValueOf(tag);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
