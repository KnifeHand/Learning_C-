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

        //How to initialize classes with the same name.
        //Both classes can be used withou having any collisions.
        //Elementary.Volume volume;
        //HighSchool.Volume volume2;
    }
}
