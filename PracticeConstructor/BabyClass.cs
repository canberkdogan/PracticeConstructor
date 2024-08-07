using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConstructor
{
    public class BabyClass
    {
        public string _name;

        public string _surname;

        public DateTime _birthDate;





        public BabyClass()  //  without parameters default constructor
        {
            CryingBaby(); 
        
        }


        public BabyClass(string name, string surname)  // Constructor with two parameters

        {
            _name = name;
            _surname = surname;

        
        }


        public void CryingBaby()    // crying message

        {
            Console.WriteLine("INGAAAAAAAAA");

            _birthDate = DateTime.Now;
        }

        public void BabyDisplay() // display baby informations

        {
            Console.WriteLine($" name {_name}, surname {_surname}, birthday { _birthDate = DateTime.Now}");


        }


    }
}
