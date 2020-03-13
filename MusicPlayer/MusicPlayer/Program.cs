using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile[] music = new MusicFile[3];

            music[0] = new MusicFile("ButterCup", "SID", 2011, 300);
            music[1] = new MusicFile("Circles", "Post Malone ", 2019, 300);
            music[2] = new MusicFile("Sunflower", "Post Malone", 2011, 160);
            Ipod ipod = new Ipod();

            ipod.Switch(true);
            ipod.Retune(99.6);
            ipod.SetVolume(99);
            ipod.ChangeChannel();

            Console.WriteLine("Switch is "+ ipod.On);
            Console.WriteLine("Frequency is "+ ipod.Frequency);
            Console.WriteLine("Volume is " + ipod.Loudness);



            for (int i=0;i<3;i++)
            {
                ipod.AddMusic(music[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                ipod.PlayNext();
            }

            for (int i = 0; i < 3; i++)
            {
                ipod.PlayPrevious();
            }

            
        }
    }
}
