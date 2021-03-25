using System;
using System.Collections;

namespace backup
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentName = new ArrayList();
            ArrayList studentGrade = new ArrayList();

            AddStudent(ref studentName, ref studentGrade);
            listStudents(ref studentName, ref studentGrade);
        }

        static void AddStudent(ref ArrayList studentName, ref ArrayList studentGrade)
        {

            Console.WriteLine("Please enter the number of students that you wish to add: ");
            int NumberOfStudents = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.WriteLine("Please enter the student's name: ");
                studentName.Add(Console.ReadLine());

                Console.WriteLine("Please enter the student's grade");
                studentGrade.Add(Console.ReadLine());
            }
        }

        static void listStudents(ref ArrayList studentName, ref ArrayList studentGrade)
        {
            for (int i = 0; i < studentName.Count; i++)
            {
                Console.Write("Student name is:{0} and their grade is: {1}.",studentName[i],studentGrade[i]);
                
                if(Convert.ToDouble(studentGrade[i]) < 60.0)
                {
                    Console.WriteLine("\tThe student has failed");
                }
                else
                {
                    Console.WriteLine("\tThe student has passed");
                }

            }
        }
    }
}




/*

using System;
using System.Collections;

namespace backup
{
    class Program
    {

        static ArrayList studentName = new ArrayList();
        static ArrayList studentGrade = new ArrayList();

        static void Main(string[] args)
        {
            AddStudent();
            listStudents();
        }

        static void AddStudent()
        {

            Console.WriteLine("Please enter the number of students that you wish to add: ");
            int NumberOfStudents = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.WriteLine("Please enter the student's name: ");
                studentName.Add(Console.ReadLine());

                Console.WriteLine("Please enter the student's grade");
                studentGrade.Add(Console.ReadLine());
            }
        }

        static void listStudents()
        {
            for (int i = 0; i < studentName.Count; i++)
            {
                Console.Write("Student name is:{0} and their grade is: {1}.",studentName[i],studentGrade[i]);
                
                if(Convert.ToDouble(studentGrade[i]) < 60.0)
                {
                    Console.WriteLine("\tThe student has failed");
                }
                else
                {
                    Console.WriteLine("\tThe student has passed");
                }

            }
        }
    }
}
 

 */