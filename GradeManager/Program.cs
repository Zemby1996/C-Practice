using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeManager
{
    public class GradeManager
    {
        
        static Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>();

        
        public void AddGrade(string studentName, int grade)
        {
            
            if (!studentGrades.ContainsKey(studentName))
            {
                studentGrades[studentName] = new List<int>();
            }

            
            studentGrades[studentName].Add(grade);
            Console.WriteLine($"Dodano ocenę: {grade} dla ucznia {studentName}");
        }

        
        public void RemoveGrade(string studentName, int grade)
        {
            if (studentGrades.ContainsKey(studentName))
            {
               
                if (studentGrades[studentName].Contains(grade))
                {
                    studentGrades[studentName].Remove(grade);
                    Console.WriteLine($"Usunięto ocenę {grade} dla ucznia {studentName}");
                }
                else
                {
                    Console.WriteLine($"Ocena {grade} nie istnieje dla ucznia {studentName}");
                }
            }
            else
            {
                Console.WriteLine($"Uczeń {studentName} nie istnieje.");
            }
        }

      
        public double CalculateAverageGrade(string studentName)
        {
           
            if (studentGrades.ContainsKey(studentName) && studentGrades[studentName].Any())
            {
                return studentGrades[studentName].Average();
            }
            else
            {
                return 0.0;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var gradeManager = new GradeManager();

            // Dodajemy oceny
            gradeManager.AddGrade("Jan", 5);
            gradeManager.AddGrade("Jan", 3);
            gradeManager.AddGrade("Jan", 2);

            // Wyświetlamy średnią ocen
            Console.WriteLine($"Średnia ocen Jana: {gradeManager.CalculateAverageGrade("Jan")}");

            // Usuwamy ocenę
            gradeManager.RemoveGrade("Jan", 2);

            // Wyświetlamy średnią po usunięciu oceny
            Console.WriteLine($"Średnia ocen Jana po usunięciu: {gradeManager.CalculateAverageGrade("Jan")}");
        }
    }
}
