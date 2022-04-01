using System;
using System.Text.RegularExpressions;
using System.IO;


namespace Week_9
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a file path: ");

            string line;

            string input = Console.ReadLine();

            var fpath = new Regex(@"^[A-Z]\S.[A-Za-z0-9]+\S.+\.[A-Za-z0-9]{3}$");


            if (fpath.IsMatch(input)) ;
            {

                File.ReadLines(input);

                string[] words = File.ReadAllLines(input);

                int count = 0;

                for (int i = 0; i < words.Length; i++)

                    count += words[i].Split(' ').Length;

                Console.WriteLine(" File path is valid \n Opening file.....\n There are " + count +
                " words in this file friends");
            }
        }
    }
}
 

