using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HJDemo
{
    class Person
    {
        public string BloodType { get; set; }

        public Person(string bloodType)
        {
            BloodType = bloodType;
            //this.bloodType = bloodType;
            //Car car = new Car();
            //car.Driver = this;
        }

        public string Name { get; set; }
        //private int Age;

        //public void SetAge(int anAge)
        //{
        //    if (anAge >= 0 && anAge <= 110) // Validation
        //        Age = anAge; // Validates!
        //    else
        //        Age = 0; // ERROR!
        //}

        //public int GetAge()
        //{
        //    return Age;
        //}

        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 0 && value <= 110) // Validation
                    age = value; // Validates!
                else
                    age = 0; // ERROR!
            }
        }

    }
}
