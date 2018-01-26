using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Id3;
using MyJukebox.Model;

namespace MyJukebox.ViewModel
{
    public class MusicFileViewModel
    {
        public void Open(string file)
        {
            using (var mp3 = new Mp3File(file))
            {
                var tag = mp3.GetTag(Id3TagFamily.FileStartTag);

                var mp3File = MusicFile.ValueOf(tag);
            }
        }
    }
}
