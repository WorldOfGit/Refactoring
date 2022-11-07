using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMediaApp
{
    internal class Mp3Converter
    {
        internal void ConvertToMp3(AudioSource source, string mimetype)
        {
            if (mimetype == "audio/mpeg")
                ConvertMpegToMp3(source);
            else if (mimetype == "audio/wav")
                ConvertWavToMp3(source);
            else if(mimetype == "audio/ogg")
                ConvertOggToMp3(source);
                
        }

        private void ConvertMpegToMp3(AudioSource source)
        {
            Console.WriteLine("Converting MPEG to MP3");
        }

        private void ConvertOggToMp3(AudioSource source)
        {
            Console.WriteLine("Converting OGG to MP3");
        }

        private void ConvertWavToMp3(AudioSource source)
        {
            Console.WriteLine("Converting WAV to MP3");
        }
    }
}
