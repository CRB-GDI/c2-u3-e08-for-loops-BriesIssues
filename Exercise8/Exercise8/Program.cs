namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" How Many even numbers?");
            int maxNumber = int.Parse (Console.ReadLine());
            int loopCounter;
            // prien even numbers up to requested max
            for (loopCounter = 0; loopCounter < maxNumber; loopCounter +=2 )
            {
                Console.WriteLine(loopCounter);
            }

            //prompt 2
            Console.WriteLine("How wide?");
            int maxwith = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxwith; i++)
            {
                //if user enters 5, should print *****
                Console.Write("*");
            }
        }
    }
}