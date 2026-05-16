namespace EpsteinFilesCSharpEdition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mathematical expression (mult. only) (ex: 2*3*4):");
            try
            {    string eval = Console.ReadLine();
                int[] numbers = eval.Split('*').Select(int.Parse).ToArray();
                int res = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    res *= numbers[i];
                }
                Console.WriteLine($"{eval} = " + res);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please enter a valid mathematical expression.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The result is too large to handle.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("");
            }
        }
    }
}
