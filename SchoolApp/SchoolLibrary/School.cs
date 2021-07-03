using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; } // Auto property uses encapsulation
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress; // backing variable that stores the value
        public string TwitterAddress
        {
            //make sure the twitter address starts with '@' symbol.
            // need to add backing variable
            get { return _twitterAddress; } // property that exposes the stored value by manipulating it.
            set
            {
                //check the value being set
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value; // what is being passed in as a value as it's being set.
                }
                else // check if invalid twitter address is being used
                {
                    // if a different value is being used other than '@' display a message.
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        //How to initialize classes with the same name.
        //Both classes can be used withou having any collisions.
        //Elementary.Volume volume;
        //HighSchool.Volume volume2;

        // Constructors to handle intialization
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        } // END Constructors

        // Methods on the Class:
        // public methods can be defined and return the same type however,
        // methods that don't need to return anything need to be instantiated 
        // with "void" as void does not require a return statement.

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        // Function bodied expression:
        // This is handy when we want to expose some very simple logic.
        // This might not be conventional if you have more complex logic that is
        // involved with a function. These are limited to simple returns.
       
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        // Overloaded method:
        // two methods with the same name but different method signatures.
        // Method signatures refer to the return type, the name, and the name type of the arguments.
        // Overloading is a form of "Polymorphism" that is a conerstone of OOP.
        // static methods:
        // These methods are methods you can call without instantiating the class.
        // For instance if you wanted to use the Math class inside a method, converting
        // a public method to a public static method allows us to use the static methods
        // of the Math class inside our function.
        // These types of methods can be seen from outside the class without us having 
        // to instantiate it. 

        public static int AverageThreeScores(int a, int b, int c)
        {
            //var temp = 15;                
            //temp.ToString();  // How to convert an integer to a string type
            var result = (a + b + c) / 3;
            return result;
        }

        // Overriding the ToString() method:
        // Every object in C# inherits from the base class object.
        // Now when we call ToString() it will apply the format we want to our
        // StringBuilder and construct the format we want to output.
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.AppendLine(", ");
            sb.AppendLine(State);
            sb.Append(" ");
            sb.AppendLine(Zip);

            return base.ToString();
        }
    } 
}
