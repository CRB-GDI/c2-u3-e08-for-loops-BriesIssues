namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" How Many even numbers");
            int maxNumber = int.Parse (Console.ReadLine());
            int loopCounter;
            // prien even numbers up to requested max
            for (loopCounter = 0; loopCounter < maxNumber; loopCounter +=2 )
            {
                Console.WriteLine(loopCounter);
            }
        }
    }
}