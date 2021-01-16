using System;

namespace Mask_Sensitive_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a secret code that's at least five characters long");
            var secretCode = Console.ReadLine();
            if (secretCode.Length >= 5)
            {
            var breakPoint = secretCode.Length - 4;
            var maskedCode = new string('*', breakPoint) + secretCode.Substring(breakPoint);
            Console.WriteLine(maskedCode);
            }
            else
            {
                Console.WriteLine("Invalid Code: Code Must Be At Least 5 Characters Long");
            }

        }
    }
}
