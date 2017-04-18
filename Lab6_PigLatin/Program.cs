using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_PigLatin
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //Declare constant variables.
            const string VOWELSTARTEXT = "way";
            const string CONSONANTSTARTEXT = "ay";
            bool run = true;
            //Display titles.
            Console.WriteLine("Welcome to the Pig Latin Translator!\n\n");
           

            do
            {
                Console.Write("Enter a word to be translated: ");
                //Read input.  Find index of first vowel.
                string input = Console.ReadLine().ToLower();

                int index = input.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });

                //Console.WriteLine(index);
                //if statment works on words that have vowel in it.
                if (index != -1)
                {
                    //Console.WriteLine(input);
                    Console.WriteLine("\nHi buddy, there is a vowel in the word you entered");

                    //Nested if to show what position the vowel is in.
                    if (index == 0)
                    {
                        Console.WriteLine("Vowel is in the first position");
                        Console.WriteLine(input + VOWELSTARTEXT);
                    }
                    else
                    {
                        //Use of SubString method to cut the first part of the word that does not contain vowels out, and append it to end of the word.
                        string subString = input.Substring(0, index);

                        // Console.WriteLine("Vowel is NOT in the first position!\n\n\n");

                        //Concatenate user input with substring of first consonants.
                        string fullString = input + subString;

                        //Removing all consonants before first letter.
                        string correctString = fullString.Remove(0, index);
                        //Console.WriteLine(correctString);
                        //Final line concatenates the correct result with suffix.
                        Console.WriteLine(correctString + CONSONANTSTARTEXT);



                        //string removedPortion = Console.ReadLine();
                        //Console.WriteLine(removedPortion);
                    }

                }

                //String entered does not a have a vowel!!!
                else
                {

                    Console.WriteLine("Hello fool, there is no vowel here!!!!! Get out! ");

                }

                //Ask user to continue.
                Console.WriteLine("Translate another line? (y/n)");
                string loop = Console.ReadLine();
                if (loop.ToLower() == "n")
                    run = false;
            } while (run);

        }

    }
}