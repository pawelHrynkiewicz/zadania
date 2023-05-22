using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_WindowsForms
{

    internal class Car
    {
        public static int LastID { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Car(string name, string model, int year)
        {
            LastID++;
            Id = LastID;
            Name= name;
            Model = model; 
            Year = year;

        }
        public override string ToString()
        {
            return $"{Id}; {Year}; {Model}; {Year}";
        }
    }


}
