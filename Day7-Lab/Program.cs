namespace Day7_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var P = new Point(10, 10, 10);
            Console.WriteLine(P);

            var P1 = new Point(1, 2, 3);

            
            Console.WriteLine("Enter");
            Console.WriteLine("P && P1\n");
            Console.WriteLine($"Equals method: {P.Equals(P1)}");
            Console.WriteLine($"== operator: {P == P1}");
            Console.WriteLine($"!= operator: {P != P1}");
           
            var P2 = new Point { X = 1, Y = 2, Z = 3 };

            Console.WriteLine("P1 && P2\n");
            Console.WriteLine($"Equals method: {P1.Equals(P2)}");
            Console.WriteLine($"== operator: {P1 == P2}");
            Console.WriteLine($"!= operator: {P1 != P2}");
        }
    }
}
