using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace Utilities.Musica
{
    public static class Canciones
    {
        public static void getVideo()
        {
            var VedioUrl = "https://www.youtube.com/embed/wvz97-lNPH8";
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(VedioUrl);
            System.IO.File.WriteAllBytes(@"c:\temp\" + video.FullName + ".mp4", video.GetBytes());
        }

        public static void getMusica()
        {
            var VedioUrl = "https://www.youtube.com/embed/wvz97-lNPH8";
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(VedioUrl);

            //string nombreCancion = video.FullName.Substring(0, video.FullName.Length - 4);
            string nombreCancion = "prueba";

            string rutaVideo = @"c:\temp\" + nombreCancion+ ".mp4";
            string rutaMusica = @"c:\temp\" + nombreCancion + ".mp3";

            System.IO.File.WriteAllBytes(rutaVideo, video.GetBytes());
             Canciones.Mp4ToMp3(rutaVideo, rutaMusica);
        }

        //https://github.com/topics/mp4?l=c%23&o=asc&s=updated

        static void Mp4ToMp3(string inputFile, string outputFile)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();
            //convert.ConvertMedia(inputFile, "video.mp4", Format.mp4);
            convert.ConvertMedia(inputFile, @"c:\temp\"+ "audio.mp3", Format.mp4);
        }
    }
}
