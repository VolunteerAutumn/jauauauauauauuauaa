namespace EpsteinFilesCSharpEdition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lim = rnd.Next() % 10 + 1;
            int[] ints = new int[lim];
            Console.WriteLine($"Enter {lim} integers from 0 to 9 :"); // try-catch practice
            for (int i = 0; i < ints.Length; i++)
            {
                try
                {
                    ints[i] = int.Parse(Console.ReadLine());
                    if (ints[i] < 0 || ints[i] > 9)
                    {
                        throw new ArgumentOutOfRangeException("Input must be between 0 and 9.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }
            string output = string.Join("", ints);
            Console.WriteLine($"Result number : {output}");
        }
    }
}
