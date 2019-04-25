using System;
using System.Collections.Generic;


namespace Linear_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Numbers = new Stack<int>();
            bool proceed = false;
            string userProceed;
            while (proceed == false)
            {
                Console.WriteLine("Please enter a number that will go into the queue.");
                string userNumbers = Console.ReadLine();
                int userOutput;
                bool isNumeric = int.TryParse(userNumbers, out userOutput);
                if (isNumeric == false)
                {
                    Console.WriteLine("Please Enter a valid number");
                }
                else
                {
                    Numbers.Push(Convert.ToInt32(userNumbers));
                    Console.WriteLine("Press S to end stop entering into Stack. Press anything else to continue entering numbers.");
                    userProceed = Console.ReadLine();
                    if (userProceed == "S" | userProceed == "s")
                    {
                        proceed = true;
                    }
                    else
                    {
                        proceed = false;
                    }
                }
            }
            foreach (int Number in Numbers)
            {
                Console.WriteLine(Number);
            }
            Console.WriteLine("Press Anything to Continue to Next Question.");
            Console.ReadKey();

            int Min = 0;
            int Max = 1000;
            int[] array = new int[1000];
            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
            }
            foreach (int i in array)
            {
                int numb = i;
            }

            int[] count = new int[1001];
            for (int x = 0; x < 1001; x++)
            {
                for (int y = 0; y < array.Length; y++)
                {
                    if (array[y] == x)
                        count[x]++;
                }
            }

                     
            for (int x = 0; x < 1001; x++)
                Console.WriteLine("Number " + x + " appears " + count[x] + " times");



            Console.ReadKey();
            {
                int n = 3;
               
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(n);
                int index = 0;
                Console.WriteLine("S =");
                while (queue.Count > 0)
                {
                    index++;
                    int current = queue.Dequeue();
                    Console.WriteLine(" " + current);
                    if (index == 50)
                    {
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.WriteLine("Index = " + index);
                        Console.ReadKey();
                        return;
                    }
                    queue.Enqueue(current + 1);
                    queue.Enqueue(2 * current);
                }
                
            }





            }

        }
}

// A linked list is useful when you need to have dynamic changes to your list without going throigh your entire list.
// In a queue or stack you must either go in an order of first-in-first out or top-to bottom respectively.
// With a linked list, you can make changes and add or remove objects in the middle of the list and both ends of the list without affecting the rest of the list.
// This is useful if you're expecting your list to change in real time and is relative.
// For example, if you want to change the placements of someone's score during putt putt golf. If player 4 is in last place, but suddenly gets a hole in one, you 
// will be able to reflect this change without the order of the order scores. Another example would be if you're going through browser history and want to 
// delete some webpages for whatever reason thawt may be, you may do so without affecting the order of the other items in the list. 
