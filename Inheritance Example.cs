using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Solution
    {
        static void Main(string[] args)
        {
            //You are given two classes, Person and Student, where Person is the base class and Student is the derived class. 
            //FOr ex his student had scores to average:  and.The student's average grade is . An average grade of  corresponds to the letter grade , so our calculate() method should return the character'O'
            try
            {
                string[] inputs = Console.ReadLine().Split();
                string firstName = inputs[0];
                string lastName = inputs[1];
                int id = Convert.ToInt32(inputs[2]);
                int numScores = Convert.ToInt32(Console.ReadLine());
                inputs = Console.ReadLine().Split();
                int[] scores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    scores[i] = Convert.ToInt32(inputs[i]);
                }

                Student s = new Student(firstName, lastName, id, scores);
                s.printPerson();
                Console.WriteLine("Grade: " + s.Calculate() + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }


    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int studentId, int[] arrScores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = studentId;
            this.testScores = arrScores;
        }

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            char cGrade = 'T';
            if (testScores.Length > 0)
            {
                double fAvgMarks = (testScores.Average());
                Console.WriteLine(fAvgMarks);
                if (fAvgMarks >= 90 && fAvgMarks <= 100)
                {
                    cGrade = 'O';
                }
                else if (fAvgMarks >= 80 && fAvgMarks < 90)
                {
                    cGrade = 'E';
                }
                else if (fAvgMarks >= 70 && fAvgMarks < 80)
                {
                    cGrade = 'A';
                }
                else if (fAvgMarks >= 55 && fAvgMarks < 70)
                {
                    cGrade = 'P';
                }
                else if (fAvgMarks >= 40 && fAvgMarks < 55)
                {
                    cGrade = 'D';
                }
            }
            return cGrade;
        }
    }
}
