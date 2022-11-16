// See https://aka.ms/new-console-template for more information
using NumberConverter;

Console.WriteLine("Enter a number");
string value = Console.ReadLine();
RomanNumberConverter converter = new();
var result =converter.ConvertDecimalToRoman(value);
Console.WriteLine(result);