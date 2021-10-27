using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Module13Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\YOGA\Downloads\Text1.txt";

            var list = new List<string>();

            var text = File.ReadAllText(path);

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            var newText = noPunctuationText.ToLower().Split(' ');

            foreach (var word in newText)
                list.Add(word);

            var popularWords = list.GroupBy(c => c).OrderByDescending(g => g.Count()).Select(g => new { Name = g.Key, Count = g.Count() }).Take(10);

            foreach (var word in popularWords)
            {
                Console.WriteLine("Слово \"" + word.Name + "\" встречается " + word.Count + " раз");
            }
        }
    }
}
