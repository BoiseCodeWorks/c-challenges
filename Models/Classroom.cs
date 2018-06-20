using System;
using System.Collections.Generic;

namespace challenges.Models
{

  public class Classroom 
  {

    public List<Student> Students { get; set; }
    public List<Attendance> AttendanceRecords { get; set; }


    public void TakeAttendance()
    {
      //create new attendance instance
      Attendance currAttendance = new Attendance();
      //itterate over students to determine status
      Students.ForEach(s =>{
        Console.WriteLine(s.Name+ ": ");
        string input = Console.ReadLine();
        if(input.ToLower() == "here")
        {
          //if here add to present
          currAttendance.AddPresent(s);
        }
        else{
          //else add to absent
          currAttendance.AddAbsent(s);
        }
      });
      //add to attendance records
      AttendanceRecords.Add(currAttendance);
      //print absent students
      System.Console.WriteLine("ABSENT STUDENTS: ");
      currAttendance.Absent.ForEach(s =>{
        System.Console.WriteLine(s.Name);
      });
    }

    public Classroom(List<Student> students)
    {
        Students = students;
        AttendanceRecords = new List<Attendance>();
    }



  }


}