﻿using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INHERITANCE");
            PrintPerson(new Student());

            Console.WriteLine("COMPOSITION");
            PrintPerson(new StudentC(new Person(), new DataAccess()));

            Console.ReadKey();
        }

        public static void PrintPerson(Student student) {
            Console.Write(student.FormatNameAndId("John Smith", 1));
        }

        public static void PrintPerson(StudentC student)
        {
            Console.Write(student.FormatNameAndId("John Smith", 1));
        }
    }
}
