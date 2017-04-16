﻿using System;
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
            //Declare variables.
            string input;
            const string VOWELSTARTEXT = "way";
            const string CONSONANTSTARTEXT = "ay";



            //Display titles.
            Console.WriteLine("Welcome to the Pig Latin Translator!\n\n");
            Console.Write("Enter a word to be translated: ");

            //Read input.  Find index of first vowel.
            input = Console.ReadLine();
            int index = input.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
            //Console.WriteLine(index);

            //if statment works on words that have vowel in it.
            if ( index != -1)
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
                    string subString2 = input.Substring(0, index);
                    Console.WriteLine("Vowel is NOT NOT NOT in the first position!\n\n\n");
                    Console.WriteLine(input + subString);
                    string fullString = input + subString;
                    Console.WriteLine(fullString);
                    string correctString = fullString.Remove(0, index);
                    Console.WriteLine(correctString);
                    Console.WriteLine(correctString + CONSONANTSTARTEXT);
                    


                    //string removedPortion = Console.ReadLine();
                    //Console.WriteLine(removedPortion);
                }

            }
           
            //String entered does not a have a vowel!!!
            else
            {

                //string FirstSubstring = input[0] + 
                Console.WriteLine("Hello fool, there is no vowel here!!!!! Get out! ");

            }





       

        }
    }
}