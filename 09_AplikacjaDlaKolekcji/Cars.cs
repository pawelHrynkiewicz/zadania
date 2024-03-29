using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _09_AplikacjaDlaKolekcji
{
    internal class Car
    {
        private static int _lastId = 0;
        public int Id;
        private string _name;
        private string _model;
        private int _year;
        public Car() { }
        public Car(string name, string model, int year)
        {
            Id = _lastId;
            _lastId++;
            _name = name;
            _model = model;
            _year = year;
        }
        public override string ToString()
        {
            return $"{_name};{_model};{_year}";
        }
        public void Show()
        {
            Console.WriteLine($"id: {Id}, name: {_name}, model: {_model}, year: {_year}");
        }
        public void ChangeName(string newName)
        {
            _name = newName;
        }
        public void ChangeModel(string newModel)
        {
            _model = newModel;
        }
        public void ChangeYear(int newYear)
        {
            _year = newYear;
        }
    };


}
