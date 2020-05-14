using System;
using Queue_library;

namespace ЛР8_Делегаты_С_sharp_ч._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[2];
            array[0] = "a";
            array[1] = "b";
            Queue<string> queue = new Queue<string>(array);
            queue.SuccessfulAction += ShowMessage;
            queue.EndQueue += ShowMessage;
            queue.Add("c");
            queue.Add("d");
            queue.Del();
            queue.Del();
            queue.Del();
            queue.Del();
        }
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
