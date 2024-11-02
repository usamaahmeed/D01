namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallPrice = 25;
            int LargePrice = 35;
            double taxRate = .06;
            int numOfSmallCarpet;
            int numOfLargeCarpet;
            int totalCost;
            double taxCost;

            Console.Write("Number of small carpets is : $");
            numOfSmallCarpet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Large carpets is : $");
            numOfLargeCarpet = Convert.ToInt32(Console.ReadLine());

            totalCost = smallPrice * numOfSmallCarpet + LargePrice * numOfLargeCarpet;

            taxCost = totalCost * taxRate;

            Console.WriteLine($"Cost : ${totalCost} ");
            Console.WriteLine($"Tax : ${taxCost} ");
            Console.WriteLine("=====================");
            Console.WriteLine($"Total estimate: ${taxCost + totalCost}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
