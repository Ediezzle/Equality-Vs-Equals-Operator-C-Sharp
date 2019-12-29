using System;
using System.Text;

namespace EqualityOperatorVsEqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "sandeep";
            string myName = name;
            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", name.Equals(myName));

            Console.WriteLine();

            object aName = "sandeep";
            char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            object theName = new string(values);
            //== compares references
            Console.WriteLine("== operator result is {0}", aName == theName);
            //Equals compares content
            Console.WriteLine("Equals method result is {0}", theName.Equals(aName));
            
            Console.WriteLine();

            string str = "sandeep";
            string myString = null;
            Console.WriteLine(str==myString);
            //works fine
            Console.WriteLine(str.Equals(myString));
            //gives an error. Null string should be the Equal's method's argument
            Console.WriteLine(myString.Equals(str)); 
        }
    }
}
