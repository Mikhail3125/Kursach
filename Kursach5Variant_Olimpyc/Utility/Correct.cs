using System;

namespace Kursach5Variant_Olimpyc.Utility
{
    public static class Correct
    {
        public static bool CorrectName(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsNumber(item))
                    result = true;
                else if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
            }
            param = "FIO";
            return result;
        }
        /*Этот метод нужен для проверки строки полетного номера. Входное значение не должно содержать символов, знаков пунктуаций, 
         * букв*/
        public static bool CorrectCountry(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsDigit(item))
                    result = true;
                else if (input.Length > 50)
                    result = true;
            }
            param = "Country";
            return result;
        }

        public static bool CorrectOlimpicPlace(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsLetter(item))
                    result = true;
                else if (input.Length > 3)
                    result = true;
                else if (Convert.ToUInt32(input) <= 0 || Convert.ToUInt32(input) >= 196)
                    result = true;
            }
            param = "Place";
            return result;
        }

        public static bool CorrectCompetition(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsDigit(item))
                    result = true;
                else if (input.Length > 30)
                    result = true;
            }
            param = "Competition";
            return result;
        }
    }
}