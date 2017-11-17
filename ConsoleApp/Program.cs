using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }


        public static void Menu()
        {
            Console.Write("4 problems:\n\n" +
                "1: Array Sorting\n" +
                "2: Transpose Matrix\n" +
                "3: Spiral Matrix\n" +
                "4: Double Array Comparison\n\n" +
                "enter 1-4 to see challenge and result: ");

            var answer = Console.ReadLine();
            switch (int.Parse(answer))
            {
                case 1: ArraySorting(); break;
                case 2: Transpose(); break;
                case 3: Spiral(); break;
                case 4: DoubleArrayCOmparison(); break;
            }
        }

        private static void ArraySorting()
        {
            Console.WriteLine("\n\n\nDesign a sorting algorithm, that will take an input array (one dimension) and sort it ascending. " +
                "Preferrable to use recursion, but any other submissions will be accepted. " +
                "Preferrable to use bubble sorting algorithm, but not mandatory." +
                "Print the sorted array");

            Console.Write("\nWrite as many numbers as you want seperated by a space or comma: ");

            var numbers = Console.ReadLine().Split();
            var numbersList = new List<int>();
            foreach (string x in numbers)
            {
                numbersList.Add(int.Parse(x));
            }


            //bubble sort
            for (int i= numbersList.Count-1; i > 0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if (numbersList[j] > numbersList[j + 1])
                    {
                        int temp = numbersList[j+1];
                        numbersList[j+1] = numbersList[j];
                        numbersList[j] = temp;                       
                    }
                }
            }

            Console.WriteLine("\nSorted: "+String.Join(", ", numbersList));

        }

        private static void Transpose()
        {
            Console.WriteLine("\n\nGiven a N x N Matrix, transpose the matrix such that the rows become columns and the columns become rows" +
                "NxN Matrix space separated column entries return character for row entries" +
                "The Matrix is NxN thus is assumed to be a square Matrix");

            Console.Write("\nMake a square matrix of any size ie: \n\n1 2 3\n4 5 6\n7 8 9\n\n");
            var numbers = Console.ReadLine().Split();


            int arrayLength = (int)Math.Sqrt(numbers.Length);        // will get length of array
            var transposed = new int[arrayLength,arrayLength];      // where the final output will go
            var num = 0;                                            // needed to index position as elements go in array

            for (int row = 0; row < arrayLength; row++)
            {
                for (int column = 0; column < arrayLength; column++)
                {
                    transposed[column, row] = int.Parse(numbers[num]);
                    num++; //increase index position
                }
            }

            // displaying transposed array
            for (int row = 0; row < transposed.GetLength(0); row++)
            {
                for (int column = 0; column < transposed.GetLength(1); column++)
                {
                    Console.Write(transposed[row, column]+ " ");
                }
                Console.Write(Environment.NewLine);
            }
        }

        private static void Spiral()
        {
            Console.WriteLine("Given an NxN matrix, you must traverse it in a spiral order, displaying all the numbers as an array" +
                "Added bonus: try to do it in the most optimal way." +
                "array of size N^2 (N squared) which contains all the elements of the matrix, traversed in a spiral order: ex:\n\n1 2 3\n4 5 6\n7 8 9\n\nis 1 2 3 6 9 8 7 4 5");

            Console.Write("\nMake a square matrix of any size ie: \n\n1 2 3\n4 5 6\n7 8 9\n\n");

            var numbers = Console.ReadLine().Split();
            int arrayLength = (int)Math.Sqrt(numbers.Length);       // will get length of array

            //a pattern shows: the number of iterations needs to complete the spiral (number of direction changes) = (arrayLength*2-1)

            for (int x = 0;x< arrayLength * 2 - 1; x++)
            {


            }

        }

        private static void DoubleArrayCOmparison()
        {
            Console.Write("4");
        }
    }
}
