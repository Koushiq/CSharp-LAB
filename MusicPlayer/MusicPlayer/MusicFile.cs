using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class MusicFile
    {
      
        private string Title { get; set; }
        private string Artist { get; set; }
        private int YearOfRelease { get; set; }
        private int DurationInSeconds { get; set; }
        public MusicFile()
        {
        }

        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.Title = title;
            this.Artist = artist;
            this.YearOfRelease = yearOfRelease;
            this.DurationInSeconds = durationInSeconds;
        }

        public void ChangeTitle(string title)
        {
            this.Title = title;
        }
        public void TrackInfo()
        {
            
            Console.WriteLine("Track Info --->");
            Console.WriteLine("Title - " + this.Title);
            Console.WriteLine("Artist - " + this.Artist);
            Console.WriteLine("Year Of Release - " + this.YearOfRelease);
            Console.WriteLine("DurationInSeconds - " + this.DurationInSeconds);
            Console.WriteLine();
        }
    }
    
}
