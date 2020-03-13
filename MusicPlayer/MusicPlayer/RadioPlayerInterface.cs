using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public interface RadioPlayerInterface
    {
         void Switch(bool on);
         void Retune(double frequency);
         void SetVolume(int loudness);
         void ChangeChannel();
    }
}
