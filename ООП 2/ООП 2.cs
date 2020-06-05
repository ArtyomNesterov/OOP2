using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ООП_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TV myTV = new TV();
            Console.WriteLine("Введите \"+\", чтобы переключить на следующий канал");
            Console.WriteLine("Введите \"-\", чтобы переключить на следующий канал");
            Console.WriteLine("Введите \"=\", чтобы ввести канал вручную");
            Console.WriteLine("Канал: " + myTV.channel);
            int channel;
            while(true)
            {
                char command = char.Parse(Console.ReadLine());
                if (command == '+' | command == '-')
                    myTV.perekl(command);
                else
                if (command == '=')
                {
                    Console.Write("Введите канал вручную: ");
                    channel = int.Parse(Console.ReadLine());
                    myTV.vvodchannel(channel);
                }
                else
                    Console.WriteLine("Некорректная команда");
                Console.WriteLine("Канал: " + myTV.channel);
            }
        }
    }

    class TV
    {
        public int channel = 1;
        public void perekl(char a)
        {
            if (a == '+')
                channel++;
            if (a == '-')
                if (channel > 1)
                    channel--;
        }
        public void vvodchannel(int a)
        {
            if (a > 1)
                channel = a;
        }
    }
}
