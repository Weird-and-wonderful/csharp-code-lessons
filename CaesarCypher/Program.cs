namespace CaesarCypher;

internal class Program
{
   static void Main(string[] args)
   {
      //get our input from the command line, or use a default value
      var input = args.FirstOrDefault("Hello, World!"); //this shows how to use the "FirstOrDefault" to get the first element from an array (or list)

      //get our shift from the command line, or use a default value
      var shift = int.Parse(args.ElementAtOrDefault(1) ?? "50"); //this shows an alternate, more flexible approach to getting command line arguments

      var caeser = new CaesarAlgorithm();



      //This code encrypts our input using the caeser cypher algorithm
      var encrypted = caeser.Encrypt(input, shift);


      //display to the user the results of our encryption
      Console.WriteLine($"Input: {input}");
      Console.WriteLine($"Shift: {shift}");
      Console.WriteLine($"Encrypted: {encrypted}");



      //YOUR ASSIGNMENT:  Implement the "Decrypt" method!
      // 1.  Create a method in the "CaeserAlgorithm" class called "Decrypt" that takes two parameters, a string and an int.
      // 2.  The method should return a string.
      // 3.  The method should reverse the encryption process, and return the original string.
      // 4.  The method should be tested in this program, by decrypting the encrypted string, and displaying the result to the user.
      // 5.  Testing: Add a new project to this solution called "CaesarCypherTests" and write tests for the "CaeserAlgorithm" class. Use XUnit.
   }
}
