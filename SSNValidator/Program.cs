// See https://aka.ms/new-console-template for more information 
 // Validate SSN

using System.Text.RegularExpressions;

Regex validateSSNRegex = new Regex("^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$");
Console.Write("Ingrese el SSN: ");
var aSSN = Console.ReadLine();
Console.WriteLine(validateSSNRegex.IsMatch(aSSN));  // prints True
         
