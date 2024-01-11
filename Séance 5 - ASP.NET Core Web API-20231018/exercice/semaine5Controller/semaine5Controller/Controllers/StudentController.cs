// HelloController.cs
using Microsoft.AspNetCore.Mvc;
using semaine5Controller;

[ApiController]
[Route("/api/[controller]")]
public class StudentController : ControllerBase
{

    [HttpGet]
    public string AllStudents()
    {
        string students = "";

        foreach(Student s in _students)
        {
            students += s.ToString() + "\n";
        }
        return students;
    }

    [HttpPost]
    public ActionResult<Student> AddStudent([FromBody] Student student)
    {
        _students.Add(student);
        return Ok();
    }

    private static List<Student> _students = new List<Student>()
        {
        new Student { Id = 1, FirstName = "Paul", LastName = "Ochon", Birthdate = new DateTime(1950, 12, 1) },
        new Student { Id = 2, FirstName = "Daisy", LastName = "Drathey", Birthdate = new DateTime(1970, 12, 1) },
        new Student { Id = 3, FirstName = "Elie", LastName = "Coptaire", Birthdate = new DateTime(1980, 12, 1) }
        };

}

