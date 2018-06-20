using System;
using System.Collections.Generic;
using challenges.Models;
using challenges.Utils;

namespace challenges
{
  class Program
  {
    static void Main(string[] args)
    {
      //FIND THE 'OUTLIER' from odds or evens
      // List<int> evenNumbers = new List<int>(){2, 4, 0, 100, 4, 11, 2602, 36};
      // List<int> oddNumbers = new List<int>(){160, 3, 1719, 19, 11, 13, -21};
      // int solution1 = Tools.OutlierFilter(evenNumbers);


      Console.Clear();
      Classroom myClassroom = new Classroom(new List<Student>(){
                new Student("Wes"),
                new Student("Alex"),
                new Student("Sam"),
                new Student("Christian"),
                new Student("Maddy")
            });
      myClassroom.TakeAttendance();
      Student removeStudent = myClassroom.Students.Find(s => s.Name.ToLower() == "allen");
      if (removeStudent != null)
      {
        myClassroom.Students.Remove(removeStudent);
      }
      else{
          System.Console.WriteLine("no such item");
      }



    }
  }
}
