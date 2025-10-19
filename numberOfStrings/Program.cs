using System;

namespace numberOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一個有意義的英文字串: ");
            var input = Console.ReadLine();
            input = input.ToLowerInvariant();//把字母都轉成小寫

            var words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);//後面那個是忽略多餘空格

            var counts = words.GroupBy(w => w)
                .ToDictionary(k => k.Key, v => v.Count());

            foreach (var ans in counts)
            {
                Console.WriteLine($"{ans.Key} : {ans.Value}");
            }

        }
    }
}
