using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_modifier_HW
{
    class Person
    {
        private readonly int id;
        private int phone;
        private string name;
        private static int numberOfPersons = 0;

        public Person(int phone, string name)
        {
            this.phone = phone;
            this.name = name;
            numberOfPersons++;
            id = numberOfPersons;
        }

        public static void ChangeName(Person myPer, string newName)
        {
            myPer.name = newName;
        }

        public static void ChangePhone(Person myPer, int newPhone)
        {
            myPer.phone = newPhone;
        }
    }
}
