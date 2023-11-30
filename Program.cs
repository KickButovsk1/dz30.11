using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colvo = 0;
            string[] array = new string[6] { "Привет", "Мама", "Россия", "Я люблю Россию", "Достижение", "Библиотека" };
            int m = 6;
            int w = 0;
            for (int i = 0; i < array.Length; i++)
            {
                w = array[i].Length;
                if (w > m)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
