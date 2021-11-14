using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estant.View.Extensions
{
    public static class MediaExtension
    {
        public static void PlayMP3ByURL(string url)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = url;
            wplayer.controls.play();
        }
    }
}
