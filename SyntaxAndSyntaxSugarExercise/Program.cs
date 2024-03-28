namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Whats your favorite number?");
          var response = int.Parse(Console.ReadLine());
            
             var answer = (response < 9) ? $"{response} is less than nine\n" :
                $"{response} is greater than or equal to nine";

            Console.WriteLine(answer);
        }
    }
}
