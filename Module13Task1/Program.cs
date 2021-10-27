using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module13Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\YOGA\Downloads\Text1.txt";

            var list = new List<char>();

            var linkedList = new LinkedList<char>();

            var text = File.ReadAllText(path);

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            var stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            foreach (var line in noPunctuationText)
                list.Add(line);
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);

            //foreach(var line in list)
            //    Console.WriteLine(line);

            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            foreach (var line in noPunctuationText)
                linkedList.AddLast(line);
            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.ElapsedMilliseconds);
        }
    }
}
