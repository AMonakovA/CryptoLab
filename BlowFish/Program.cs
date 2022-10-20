using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowFish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст, который необходимо зашифровать/расшифровать.");
            string plainText = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите ключ.");
            var key = Console.ReadLine();
            BlowFish b = new BlowFish(key);

            ConsoleKeyInfo operation;
            while (true)
            {
                Console.WriteLine("Что необходимо сделать? \nЕсли вы хотите зашифровать - нажмите Q, если необходимо расшифровать - нажмите W.");
                 operation = Console.ReadKey();
                if ( (operation.Key == ConsoleKey.Q))
                {
                    var cipherText = b.Encrypt_ECB(plainText);
                    Console.WriteLine($"\n{cipherText}");
                    break;
                }
                if ((operation.Key == ConsoleKey.W))
                {
                    var decryptText = b.Decrypt_ECB(plainText);
                    Console.WriteLine($"\n{decryptText}");
                    break;
                }
                else
                {
                    Console.WriteLine("\nПожалуйста попробуйте еще раз.");
                }
            }
             Console.ReadKey();

        }
    }
   
}
