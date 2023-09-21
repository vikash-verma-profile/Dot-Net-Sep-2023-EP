using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Day_5
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void WriteToFile(Student s, string FilePath)
        {

            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine(JsonConvert.SerializeObject(s));
            sw.Flush();
            sw.Close();
        }
        public Student ReadFromFile(string FilePath)
        {
            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string output = sr.ReadLine();
            return JsonConvert.DeserializeObject<Student>(output);
        }
    }
    internal class StudentData
    {
        static void Main2(string[] args)
        {
            string FilePath = "C:\\Users\\om\\Desktop\\Dot-Net-Core\\Labs\\Day-5\\Day-5\\files\\test.txt";
            Student s = new Student(1, "Suresh kumar");
            s.WriteToFile(s, FilePath);
            var std = s.ReadFromFile(FilePath);
            Console.WriteLine("Student ID: " + std.Id);
            Console.WriteLine("Student Name: " + std.Name);
        }
    }
}
