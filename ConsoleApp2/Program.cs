using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "My video"};
            var videoEncoder = new VideoEncoder(); //publisher

            var mail = new MailService();
            var message = new MessageService();

            videoEncoder.VideoEncoded += message.OnVideoEncoded;            
            videoEncoder.VideoEncoded += mail.OnVideoEncoded;

            
            videoEncoder.Encode(video); 
        }
    }
}



