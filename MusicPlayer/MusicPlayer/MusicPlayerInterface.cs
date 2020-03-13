using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public interface MusicPlayerInterface
    {
        void Switch(bool on);
        void Play(bool on);
        void SetVolume(int loudness);
        void PlayNext();
        void PlayPrevious();
    }
}
