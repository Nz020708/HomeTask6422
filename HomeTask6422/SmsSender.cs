using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6422
{
    class SmsSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Gondermek istediyiniz texti daxil edin:");
            string text = Console.ReadLine();
            while (text == "" || text == " ")
            {
                Console.WriteLine("Mesaj gonderile bilmedi.");
                if (text == "" || text == " ")
                {
                    Console.WriteLine("Yeniden gondermek istediyiniz texti daxil edin:");
                    text = Console.ReadLine();
                }

            }
            Console.WriteLine("Mesajiniz ugurla gonderildi.");
        }
    }
}
