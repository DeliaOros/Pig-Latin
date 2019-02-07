using System;
using System.Collections.Generic;


namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = @" If a word begins with a vowel sound, add an ""ay"" sound to the end of the word.";            

            var myText = text.stringEngToPigLatinTranslator();

            Console.WriteLine(myText);



        }


    }
}
