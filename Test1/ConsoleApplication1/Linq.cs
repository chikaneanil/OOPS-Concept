using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace ConsoleApplication1
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }

    class Linq
    {

        public class ListtoDataTable
        {
            public DataTable ToDataTable<T>(List<T> items)
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                //Get all the properties by using reflection   
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names  
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
        }
        //static void Main(string[] args)
        //{
        //    List<string> countries = new List<string>();
        //    countries.Add("India");
        //    countries.Add("US");
        //    countries.Add("Australia");
        //    countries.Add("Russia");

        //    var result1 = from u in countries
        //                  select u;
            
        //    IEnumerable<string> result = countries.Select(x => x);
        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine(" ");
        //    Console.ReadLine();

            //    //---------------------------------Even Number Using LINQ------------------------
            //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //    Console.WriteLine("Below are the even numbers");
            //    int minimumNum = numbers.Min();
            //    int maximumNum = numbers.Max();
            //    int addition = numbers.Sum();
            //    int Count = numbers.Count();
            //    int aggregate = numbers.Aggregate((a, b) => a * b);
            //    Console.WriteLine("Minimum Number :" + minimumNum);
            //    Console.WriteLine("Maximum Number :" + maximumNum);
            //    Console.WriteLine("Addition Number :" + addition);
            //    Console.WriteLine("Number Of Count :" + Count);
            //    Console.WriteLine("Aggregate Number :" + aggregate);

            //    IEnumerable<int> evennumber = numbers.Where(x => x % 2 == 0);
            //    foreach (var item in evennumber)
            //    {
            //        Console.WriteLine(item + " is an even number");
            //    }

            //    //        //----------------------------Select Query Synatx----------------------------------
            //    List<Student> Objstudent = new List<Student>()
            //    {
            //    new Student() { StudentId = 1, Name = "Suresh", Marks = 500 },
            //    new Student() { StudentId = 2, Name = "Rohini", Marks = 300 },
            //    new Student() { StudentId = 3, Name = "Madhav", Marks = 400 },
            //    new Student() { StudentId = 4, Name = "Sateesh", Marks = 550 },
            //    new Student() { StudentId = 5, Name = "Praveen", Marks = 600 },
            //    new Student() { StudentId = 6, Name = "Sudheer", Marks = 700 },
            //    new Student() { StudentId = 7, Name = "Prasad", Marks = 550 }
            //    };

            //    var result3 = from s in Objstudent
            //                  select new { SName = s.Name, SID = s.StudentId, SMarks = s.Marks };

            //    foreach (var item in result3)
            //    {
            //        Console.WriteLine("The StudentName is {0} ID is {1} Marks is {2}", item.SName, item.SID, item.SMarks);
            //    }

            //    //        ////--------------------------Select Operator Synatx -----------------------------------
            //    List<Student> Objstudent1 = new List<Student>()
            //    {
            //    new Student() { StudentId = 1, Name = "Suresh", Marks = 500 },
            //    new Student() { StudentId = 2, Name = "Rohini", Marks = 300 },
            //    new Student() { StudentId = 3, Name = "Madhav", Marks = 400 },
            //    new Student() { StudentId = 4, Name = "Sateesh", Marks = 550 },
            //    new Student() { StudentId = 5, Name = "Praveen", Marks = 600 },
            //    new Student() { StudentId = 6, Name = "Sudheer", Marks = 700 },
            //    new Student() { StudentId = 7, Name = "Prasad", Marks = 550 }
            //    };

            //    var result4 = Objstudent1.Select(student => new
            //    {
            //        SName = student.Name,
            //        SID = student.StudentId,
            //        SMarks = student.Marks
            //    });

            //    foreach (var item in result4)
            //    {
            //        Console.WriteLine("The StudentName is {0} ID is {1} Marks is {2}", item.SName, item.SID, item.SMarks);
            //    }

            //    //        //----------------------------------------Select many ( Select Collection From Collection)----------------
            //List<Student> Objstudent2 = new List<Student>()
            //{
            //new Student() { Name = "Ravi Varma", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
            //new Student() { Name = "Vikram Sharma", Gender = "Male", Subjects = new List<string> { "Social Studies", "Chemistry" } },
            //new Student() { Name = "Harish Dutt", Gender = "Male", Subjects = new List<string> { "Biology", "History", "Geography" } },
            //new Student() { Name = "Akansha Wadhwani", Gender = "Female", Subjects = new List<string> { "English", "Zoology", "Botany" } },
            //new Student() { Name = "Vikrant Seth", Gender = "Male", Subjects = new List<string> { "Civics", "Drawing" } }
            //};

            //    var Subjects = Objstudent2.SelectMany(x => x.Subjects);
            //    foreach (var subject in Subjects)
            //    {
            //        Console.WriteLine(subject);
            //    }
            //    Console.ReadLine();
            //}




            //ListtoDataTable lsttodt = new ListtoDataTable();
            //DataTable dt = lsttodt.ToDataTable(Objstudent2);

        //}
    }

}