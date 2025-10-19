namespace progressiveTax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入年收入: ");

            decimal input = decimal.Parse(Console.ReadLine());

            decimal[] levels = { 540000, 1210000, 2420000, 4530000, 10310000, decimal.MaxValue };

            decimal[] rates = { 0.05m, 0.12m, 0.20m, 0.30m, 0.40m, 0.50m };

            decimal tax = 0m;

            decimal currentLevel = 0m;

            for (int i = 0; i < levels.Length; i++)
            {
                if (input <= currentLevel) break;

                tax += (Math.Min(input, levels[i]) - currentLevel) * rates[i];
                
                currentLevel = levels[i];
            }

            Console.WriteLine($"{input} -> {tax}");
        }
    }
}
