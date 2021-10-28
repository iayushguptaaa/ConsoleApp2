using System;
using System.Threading;

namespace ConsoleApp2
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sending Text Message...");
            Thread.Sleep(1000);
            Console.WriteLine("Message sent");
        }
    }
}



