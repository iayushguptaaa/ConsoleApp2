using System;
using System.Threading;

namespace ConsoleApp2
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sending Mail...");
            Thread.Sleep(5000);
            Console.WriteLine("Mail sent");
        }
    }
}



