using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace semaine5Controller
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = new DateTime(1980, 12, 1);
        }

        public Student()
        {
        }
        public int Id { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime Birthdate { get; internal set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " : " + Birthdate;
        }
    }
}
