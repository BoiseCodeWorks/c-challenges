using System;
using System.Collections.Generic;

namespace challenges.Models
{
  public class Attendance
  {
    public DateTime Date { get; set; }
    public List<Student> Absent { get; set; }
    public List<Student> Present { get; set; }


    public void AddAbsent(Student student)
    {
      Absent.Add(student);
    }

    public void AddPresent(Student student)
    {
      Present.Add(student);
    }

    public Attendance()
    {
      Date = DateTime.Now;
      Absent = new List<Student>();
      Present = new List<Student>();
    }
  }

}