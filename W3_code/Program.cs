using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _Barashada_C_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Output //
            // To output values or print text in C#, you can use the WriteLine() method:
            // Example
            Console.WriteLine("Hello World!");
            // You can add as many WriteLine() methods as you want. Note that it will add a new line for each method:


            //Example//  Console.WriteLine();

            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");


            // You can also output numbers, and perform mathematical calculations:
            // Example  //

            Console.WriteLine(3 + 3);
            Console.WriteLine(3 * 3);
            Console.WriteLine(3 - 3);
            Console.WriteLine(6 / 3);
            Console.WriteLine(10 % 3); // Modulus (remainder) Baaqi ama tirada hartay..


            // The Write Method//
            //There is also a Write() method, which is similar to WriteLine(). Qoraalka ayuu u soo daabacayaa hal saddar.
            //The only difference is that it does not insert a new line at the end of the output:
            //Example//
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");


            // C# Variables // Variables are containers for storing data values.

            // In C#, there are different types of variables (defined with different keywords), for example:

            //  int -stores integers(whole numbers), without decimals, such as 123 or - 123

            //  double -stores floating point numbers, with decimals, such as 19.99 or - 19.99

            //  cha -stores single characters, such as 'a' or 'B'.Char values are surrounded by single quotes

            //  string -stores text, such as "Hello World".String values are surrounded by double quotes

            //  bool -stores values with two states: true, false, one, or zero, yes or no, on or off.   only two possible values.

            // Example

            Console.WriteLine("Name");

            // declare a variable and assign a value. intialize variable,

            string name = "Garaad"; // string studentName = "Garaad";


            int Age = 25; // int myNum = 15; // Integer (whole number)

            Char characters = 'A'; // Char letter = 'A'; // Character

            float distabce_Resa = 1.1234567f;  //  Use float for graphics and performance-sensitive tasks.

            double Wieght = 1.123456789012345; //  Use double for general math and science.

            decimal priceDecimal = 0.1m + 0.2m; // Use decimal for money, finance, currency, accounting.

            bool G = true; // bool isStudent = true; // Boolean 
            bool H = false; // bool isStudent = false; // Boolean


            // C# Data Types //
            // As explained in the variables chapter, a variable in C# must be a specified data type:
            // Example //

            int Id = 25;             // int = Data Type, Id =  Variable Name, 25 = Value
            Console.WriteLine(Id);// Integer (whole number)

            double myDoubleNum = 5.99D;  // Floating point number
            Console.WriteLine(myDoubleNum);

            char myLetter = 'D';         // Character
            Console.WriteLine(myLetter);

            bool myBool = true;          // Boolean
            Console.WriteLine(myBool);

            string myText = "Hello";     // String
            Console.WriteLine(myText);

            int myNum = 15;
            Console.WriteLine(myNum);

            myNum = 20;                   // myNum is now 20    
            Console.WriteLine(myNum);



            // Constants// constants are like variables, but their values cannot be changed.
            // Data type marka laga hormariyo const keyword lama badali karo qiimaha aad ku shubato variable name  kaaga
            // If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.

            // This will declare the variable as "constant", which means unchangeable and read-only:

            // Example //
            const int myNum1 = 15;
            //myNum = 20; // error

            string carName = "Volvo";

            const string birthCity = "Mogadishu";
            // birthCity = "Hargeisa"; // error

            const double pi = 3.14159;
            // pi = 3.14; // error


            // OK, but not so easy to understand what m actually is




            //Display Variables//
            //The WriteLine() method is often used to display variable values to the console window.

            // To combine both text and a variable, use the +character:

            // Example

            string Name = "Garaad";

            Console.WriteLine(name);

            Console.WriteLine("Hi" + name);
            Console.WriteLine("Magacayga waa : " + name);

            // Example 3 

            Console.Write("magacaygu waaa ");
            Console.Write(name);

            Console.WriteLine(" My name is" + name);

            string firstName = "Garaad";
            string lastName = "Jilacow";
            string fullName = firstName + lastName;
            Console.WriteLine("fullName");

            //For numeric values, the + character works as a mathematical operator (notice that we use int(integer) variables here):
            // Example
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y
            Console.WriteLine(x * y);
            Console.WriteLine(x - y);
            Console.WriteLine(x / y);



            //Multiple Variables//
            // Example

            int A = 5, B = 6, C = 20;

            Console.WriteLine(A + B + C);

            //You can also assign the same value to multiple variables in one line:
            // Example
            int a, b, c; // Declare multiple variables on one line

            a = b = c = 50; // Assign the same value to multiple variables on one line

            Console.WriteLine(a + b + c);


            //  C# Identifiers

            // All C# variables must be identified with unique names.

            // These unique names are called identifiers.

            // Identifiers can be short names(like x and y) or more descriptive names(age, sum, totalVolume).

            //Note: It is recommended to use descriptive names in order to create understandable and maintainable code:

            // Example //
            int minutesPerHour = 60;
            int m = 60;
            Console.WriteLine(minutesPerHour);
            Console.WriteLine(m);

            // Both variables above are perfectly valid, but the first variable is more descriptive and understandable.
            // Naming Variables Rules //

            // The general rules for naming variables are://
            // Names can contain letters, digits and the underscore character(_)
            //  Names must begin with a letter or underscore
            //   Names should start with a lowercase letter, and cannot contain whitespace
            //   Names are case -sensitive("myVar" and "myvar" are different variables)//
            //  Reserved words(like C# keywords, such as int or double) cannot be used as names


            //C# Data Types
            // As explained in the variables chapter, a variable in C# must be a specified data type:
            // Example //

            int myId = 25;             // int = Data Type, myId =  Variable Name, 25 = Value
            Console.WriteLine(myId);// Integer (whole number)

            double myDoubleNum1 = 5.99D;  // Floating point number
            Console.WriteLine(myDoubleNum1);

            char myLetter1 = 'D';         // Character
            Console.WriteLine(myLetter1);

            bool myBool1 = true;          // Boolean
            Console.WriteLine(myBool1);

            string myText1 = "Hello";     // String
            Console.WriteLine(myText1);

            // Data Type	Size	Description//
            // int 4 bytes Stores whole numbers from - 2,147,483,648 to 2,147,483,647
            // long    8 bytes Stores whole numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // float   4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            // double  8 bytes Stores fractional numbers.Sufficient for storing 15 decimal digits
            // bool    1 byte  Stores true or false values
            // char    2 bytes Stores a single character / letter, surrounded by single quotes
            // string  2 bytes per character
            // decimal 16 bytes Stores fractional numbers. Sufficient for storing 28-29 decimal digits

            // Numbers
            // Number types are divided into two groups:
            // Integer types: stores whole numbers, positive or negative (such as 123 or -456), without decimals. Valid types are (int and long).
            // Which type you should use, depends on the numeric value.
            // Floating point types: represents numbers with a fractional part, containing one or more decimals. Valid types are (float and double).

            // Integer Types //
            // The int data type can store whole numbers from -2147483648 to 2147483647. In general, and in our tutorial,
            // the int data type is the preferred data type when we create variables with a numeric value.

            // Example //
            // int myNum = 100000;
            Console.WriteLine(myNum);

            // Long //
            // The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807.
            // This is used when int is not large enough to store the value. Note that you should end the value with an "L":
            // Example //
            long myNum2 = 15000000000L;
            Console.WriteLine(myNum);

            // Floating Point Types //
            // You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.
            // The float and double data types can store fractional numbers.
            // Note that you should end the value with an "F" for floats and "D" for doubles:

            // Float Example//
            float myNum3 = 5.75F;
            Console.WriteLine(myNum);

            //Double Example//
            double myNum4 = 19.99D;
            Console.WriteLine(myNum);

            // Use float or double? //
            // The precision of a floating point value indicates how many digits the value can have after the decimal point.
            // The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits.
            // Therefore it is safer to use double for most calculations.

            // Scientific Numbers //
            // A floating point number can also be a scientific number with an "e" to indicate the power of 10:

            // Example //
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            // Booleans //
            // A boolean data type is declared with the bool keyword and can only take the values true or false:

            // Example //
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False
            // Boolean values are mostly used for conditional testing, which you will learn more about in a later chapter.


            // Characters //
            //The char data type is used to store a single character. The character must be surrounded by single quotes, like 'A' or 'c':
            // Example //
            char myGrade = 'B';
            Console.WriteLine(myGrade);
            // Strings //
            // The string data type is used to store a sequence of characters (text). String values must be surrounded by double quotes:

            // Example //
            string greeting = "Hello World";
            Console.WriteLine(greeting);


            // C# Type Casting // 
            // Type casting is when you assign a value of one data type to another type.
            // In C#, there are two types of casting:

            // Implicit Casting(automatically) -converting a smaller type to a larger type size
            // (char -> int -> long -> float -> double)

            // Explicit Casting(manually) - converting a larger type to a smaller size type
            // (double -> float -> long -> int -> char)

            //Implicit Casting//
            //Implicit casting is done automatically when passing a smaller size type to a larger size type:
            // Example //

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Explicit Casting //
            // Explicit casting must be done manually by placing the type in parentheses in front of the value:

            // Example //
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9
            // Type Conversion Methods //
            // It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean,
            // Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

            // Example //
            int myInt4 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;


            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string












            Console.WriteLine("Hi Garaad!"); // Console.WriteLine= waa soo saare ama soo daa bace //
            Console.WriteLine("Jag är Buss driver");

            Console.WriteLine("my name is Garaad");

            Console.WriteLine(5 + 3);

            Console.WriteLine(7 - 3);

            Console.WriteLine(3 * 3);

            Console.WriteLine(9 / 3);

            Console.WriteLine(10 % 3);

            Console.WriteLine(myNum);
        }
    }
}
