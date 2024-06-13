using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Tae";
            var lastName = "Albert";
            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "CT", "Gordon", "Tegan" };
            var formattedNames = string.Join(", ", names); //the first value is the separater, the second is the array
            Console.WriteLine("My favorite pets: " + formattedNames);

        }
    }
}

