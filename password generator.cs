using System;


namespace Workingwithfiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + rand.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);

        }  
    }
}


