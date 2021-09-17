using System;

/*
 * Vowel Shifter
 * 
 * Write a program that prompts the user for a sentence and modifies it by shifting each vowel like this:
 *      • a → e             A → E
 *      • e → i             E → I
 *      • i → o             I → O
 *      • o → u             O → U
 *      • u → a             U → A
 *
 * In other words, each "a" in the original sentence becomes an "e", each "e" in the original sentence
 * becomes an "i", and so on, and similarly for capital letters.
 *
 * The following test cases illustrate the required I/O format.
 *
 * Enter a sentence: Your powers are weak, old man!
 * Yuar puwirs eri wiek, uld men!
 *
 * Enter a sentence: I find your lack of faith disturbing.
 * O fond yuar leck uf feoth dostarbong.
 *
 * Enter a sentence: I can take you as far as Anchorhead.
 * O cen teki yua es fer es Enchurhied.
 *
 * As shown by the third test case, capitalized vowels may appear anywhere within the input sentence.
 */

namespace VowelShifter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            
            // In C#, strings can be accessed similar to arrays
            Console.WriteLine($"Before: {input}");

            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                // Let's grab one character from the input at index i
                char current = input[i];
                
                // Turn any 'e' to a '3'
                if (current == 'a')
                {
                    current = 'e';
                } else if (current == 'e')
                {
                    current = 'i';
                } else if (current == 'i')
                {
                    current = 'o';
                } else if (current == 'o')
                {
                    current = 'u';
                } else if (current == 'u')
                {
                    current = 'a';
                } else if (current == 'A')
                {
                    current = 'E';
                } else if (current == 'E')
                {
                    current = 'I';
                } else if (current == 'I')
                {
                    current = 'O';
                } else if (current == 'O')
                {
                    current = 'U';
                } else if (current == 'U')
                {
                    current = 'A';
                }

                output += current;
            }
            
            Console.WriteLine($"After: {output}");
        }
    }
}