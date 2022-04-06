using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6422
{
    class EmailSender : MessageSender
    {

        public override void SendMessage()
        {
            Console.WriteLine("Gondermek istediyiniz istifadechinin emailini daxil edin:");
            string email = Console.ReadLine();
            for (int i = 0; i < email.Length; i++)
            {
                if (email == "" || email == " ")
                {
                    Console.WriteLine("Emaili duzgun daxil edin:");
                    email = Console.ReadLine();
                }
                else if (email[i] != '@' && email[i] != '.' && !Char.IsLetterOrDigit(email[i]))
                {
                    Console.WriteLine("Emaili duzgun daxil edin:");
                    email = Console.ReadLine();
                }
            }
        
            
            Console.WriteLine($"Daxil olundu:{email}");
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
