namespace contentReplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max;
            Console.Write("請輸入一個大於90的整數: ");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out max) && max > 90)
                {
                    break;
                }
                else
                {
                    Console.Write("輸入錯誤，請重新輸入: ");
                }
            }
            Enumerable.Range(1, max)
                .Select(i =>
                (i % 3 == 0 && i % 5 == 0) ? "Dann" :
                (i % 3 == 0) ? "Build" :
                (i % 5 == 0) ? "School" : i.ToString())
                .ToList().ForEach(Console.WriteLine);

            //IEnumerable<string> ans = Enumerable.Range(1, max)
            //    .Select(i =>
            //    (i % 3 == 0 && i % 5 == 0) ? "Dann" :
            //    (i % 3 == 0) ? "Build" :
            //    (i % 5 == 0) ? "School" : 
            //    i.ToString());
            //foreach (string res in ans)
            //{
            //    Console.WriteLine(res);
            //}
        }
    }
}
