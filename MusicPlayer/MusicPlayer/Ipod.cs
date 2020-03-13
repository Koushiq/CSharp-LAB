using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Ipod : RadioPlayerInterface, MusicPlayerInterface
    {
        private MusicFile [] musicFile;
        private int indexOfMusicFile;
        private int currentTrack;
        public bool On { get; set; }
        public double Frequency { get; set; }
        public int Loudness { get; set; }


        public Ipod()
        { 
            this.musicFile= new MusicFile[500];
            this.indexOfMusicFile = 0;
            this.currentTrack = 0;
        }
        public void AddMusic(MusicFile music)
        {
            if(this.indexOfMusicFile < 500)
            {
                this.musicFile[this.indexOfMusicFile] = music;
                this.indexOfMusicFile++;
            }
            else
            {
                Console.WriteLine("Not Possible!");
            }
        }

        public void Switch(bool on)
        {
            this.On = on;
        }
        public void Retune(double frequency)
        {
            this.Frequency = frequency;
        }
        public void SetVolume(int loudness)
        {
            this.Loudness = loudness;
        }
        public void ChangeChannel()
        {
            Console.WriteLine("Channel Changed!");
        }
        void MusicPlayerInterface.Switch(bool on)
        {
            this.On = on;
        }

        public void Play(bool on)
        {
            this.On = on;
        }
        void MusicPlayerInterface.SetVolume(int loudness)
        {
            this.Loudness = loudness;
        }

        public void PlayNext()
        {
            if(this.currentTrack+1>=this.indexOfMusicFile)
            {
                Console.WriteLine("No more tracks available");
            }
            else
            {
                Console.WriteLine("Playing next Track");
                Console.WriteLine();
                this.currentTrack++;
                Console.WriteLine("Now Playing!");
                this.musicFile[this.currentTrack].TrackInfo();
            }
        }

        public void PlayPrevious()
        {
            if (this.currentTrack-1<0)
            {
                Console.WriteLine("No more tracks available !");
                
            }
            else
            {
                Console.WriteLine("Playing previous Track");
                Console.WriteLine();
                this.currentTrack--;
                Console.WriteLine("Now Playing!");
                this.musicFile[this.currentTrack].TrackInfo();
            }
        }

       
    }
}
