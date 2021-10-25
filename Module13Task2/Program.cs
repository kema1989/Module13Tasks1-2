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

            var dict = new Dictionary<long, string>();

            var list = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                var text = sr.Read();
                var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
                foreach (var word in noPunctuationText)
                {
                    list.Add(word);
                }
            }
        }
    }
}
