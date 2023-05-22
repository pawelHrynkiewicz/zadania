using _15_BazaDanychWlasne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// PYTANIA DO PROWADZĄCEGO
/// 1. W SQL GPA zadeklarowałem jako float, jednak c# nie pozwala mi wrzucić tego do floata
///w aplikacji i musze użyć double. Jaka jest róznica miedzy float w SQG a w C#?
namespace _15_BazaDanychWlasne
{
    internal class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Major { get; set; }
        public int Year { get; set; }
        public double GPA { get; set; }
        public Student(int id, string lastName, string firstName, string major, int year, double gpa)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Major = major;
            Year = year;
            GPA = gpa;
        }
        public Student(string lastName, string firstName, string major, int year, double gpa)
        {
            LastName = lastName;
            FirstName = firstName;
            Major = major;
            Year = year;
            GPA = gpa;
        }
        public override string ToString()
        {
            return $"ID: {Id}; Nazwisko: {LastName}; Imie: {FirstName}; Kierunek: {Major}; Rok: {Year}; Srednia: {GPA}";
        }

    }

}

