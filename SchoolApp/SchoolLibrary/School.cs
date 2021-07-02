using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {
        string Name { get; set; } // Auto property uses encapsulation
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string PhoneNumber { get; set; }
        string _twitterAddress; //backing variable that stores the value
        string TwitterAddress
        {
            //make sure the twitter address starts with @
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
    }
}
