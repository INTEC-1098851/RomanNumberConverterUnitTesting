using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    public class RomanNumberConverter
    {
        private Dictionary<string,int> conversionDictionary { get; set; }
        public RomanNumberConverter()
        {
            conversionDictionary = new();
            conversionDictionary.Add("M", 1000);
            conversionDictionary.Add("CM", 900);
            conversionDictionary.Add("D", 500);
            conversionDictionary.Add("CD", 400);
            conversionDictionary.Add("C", 100);
            conversionDictionary.Add("XC", 90);
            conversionDictionary.Add("L", 50);
            conversionDictionary.Add("XL", 40);
            conversionDictionary.Add("X", 10);
            conversionDictionary.Add("IX", 9);
            conversionDictionary.Add("V", 5);
            conversionDictionary.Add("IV", 4);
            conversionDictionary.Add("I", 1);           
        }
        public string ConvertDecimalToRoman(string? numValue = null)
        {
            decimal num;
            var res = decimal.TryParse(numValue, out num);
            if (!res || num == null)
                return "Must enter a number";
            if (num < 1 || num > 3999)
                return "Must enter a number between 1 and 3999";
            var romanNumber = "";
            for(int i = 0; i < conversionDictionary.Count; i++)
            {
                while (conversionDictionary.Any(x => num >= x.Value))
                {
                    var keyValuePairs = conversionDictionary.FirstOrDefault(x => num >= x.Value);
                    num-=keyValuePairs.Value;
                    romanNumber += keyValuePairs.Key;
                }
            }
            return romanNumber;
        }
    }
}
