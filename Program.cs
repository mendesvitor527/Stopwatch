using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundos -> 10s = 10 segundos");
            Console.WriteLine("M = Minuto -> 1m = 1 minuto");
            Console.WriteLine("00 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0,data.Length - 1));
            MenuController(type, time);
        }

        static void MenuController(char type, int time){
            if (type == 'm'){
                int newTime = MinuteToSeconds(time);
                Start(newTime);
            }

            if (type == 's')
                Start(time);

            if (type == '0')
                System.Environment.Exit(0);
        }

        static int MinuteToSeconds(int time){
            int seconds = time * 60;
            return seconds;
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2000);
        }
    }
}
