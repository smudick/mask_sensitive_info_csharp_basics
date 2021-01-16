using System;

namespace Mask_Sensitive_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mask Sensitive Information

            Console.WriteLine("Enter a secret code that's at least five characters long");
            var secretCode = Console.ReadLine();
            var breakPoint = secretCode.Length - 4;
            var maskedCode = new String('*', breakPoint) + secretCode.Substring(breakPoint);
            Console.WriteLine(maskedCode);

        }
    }
}
