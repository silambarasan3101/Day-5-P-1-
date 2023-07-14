using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5__P_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };
            Console.WriteLine("Student 1:");
            for (int i = 0; i < studentScores[0].Length; i++)
            {
                Console.Write(studentScores[0][i]+"\t");
            }
            Console.WriteLine("\nStudent 2:");
            for (int i = 0; i < studentScores[1].Length; i++)
            {
                Console.Write(studentScores[1][i]+"\t");
            }
            Console.WriteLine("\nStudent 3:");
            for (int i = 0; i < studentScores[2].Length; i++)
            {
                Console.Write(studentScores[2][i]+"\t");
            }          
            int student1Average = 0;
            for (int i = 0; i < studentScores[0].Length; i++)
            {
                student1Average += studentScores[0][i];
            }
            student1Average /= studentScores[0].Length;
            int student2Average = 0;
            for (int i = 0; i < studentScores[1].Length; i++)
            {
                student2Average += studentScores[1][i];
            }
            student2Average /= studentScores[1].Length;
            int student3Average = 0;
            for (int i = 0; i < studentScores[2].Length; i++)
            {
                student3Average += studentScores[2][i];
            }
            student3Average /= studentScores[2].Length;
            Console.WriteLine("\nStudent 1 average: " + student1Average);
            Console.WriteLine("Student 2 average: " + student2Average);
            Console.WriteLine("Student 3 average: " + student3Average);
            int totalScore = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalScore += studentScores[i][j];
                }
            }
            int averageScore = totalScore / studentScores.Length;

            Console.WriteLine("\nAverage score for all students: " + averageScore);
            Console.ReadKey();
        }
    }
}
        
    

