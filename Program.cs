// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace RegexPracticeProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the EmailId");
            string code = Console.ReadLine();

            Pattern patterns = new Pattern();
            bool val = patterns.validatePincode(code);

            if (val)
            {
                Console.WriteLine("Matched");
            }
            else
            {
                Console.WriteLine("Not Matched");
            }
        }
    }
}