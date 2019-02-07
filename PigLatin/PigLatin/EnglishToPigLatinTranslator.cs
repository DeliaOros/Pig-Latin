using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    public static class EnglishToPigLatinTranslator
    {

        private static bool IsVowel(char letter)
        {
            var vowels = new List<char> { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };
            if (vowels.Contains(letter))
            {
                return true;
            }
            return false;
        }

        public static string stringEngToPigLatinTranslator(this string text)
        {
            var translation = new StringBuilder();

            if (text != "")
            {
                var tempText = text.Split(new[] { ';', ',', '.', ' ', '"' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in tempText)
                {

                    var letter = item[0];
                    var vowel = IsVowel(letter);
                    if (vowel == true)
                    {
                        translation.Append(item + "ay" + " ");
                    }
                    else
                    {
                        translation.Append(item.ToLower().Remove(0, 1) + letter + "ay" + " ");
                    }

                }

                return translation.ToString().TrimEnd();
            }
            Console.WriteLine("No input, nothing to return");
            return "";

        }
    }
}

