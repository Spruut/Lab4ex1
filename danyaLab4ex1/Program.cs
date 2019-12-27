using System;

namespace danyaLab4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "hello world";
            //char ch = 'o';
            //int ind = str.LastIndexOf(ch);
            //Console.WriteLine(ind);
            //string text = "Хороший день";
            //string subString = "замечательный ";

            //text = text.Insert(8, subString);
            //Console.WriteLine(text);

            //// индекс последнего символа
            //int ind = text.Length - 1;
            //// вырезаем последний символ
            //text = text.Remove(ind);
            //Console.WriteLine(text);

            //// вырезаем первые два символа
            //text = text.Remove(0, 2);
            //text = text.Replace("Хороший", "Плохой");
            //Console.WriteLine(text);

            //text = text.Replace("о", "");
            //Console.WriteLine(text);

            Console.WriteLine("enter sentence:");
            string sent = Console.ReadLine();
            for(int i = 0; i < sent.Length; i++)
            {
                if (sent.IndexOf(sent[i]) == sent.LastIndexOf(sent[i])) 
                {
                    Console.Write($"{sent[i]} ");
                }
            }
        }
    }
}
