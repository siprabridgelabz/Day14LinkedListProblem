﻿namespace Day14LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list operation");
            LinkedList list = new LinkedList();

            // Console.WriteLine("Search element" + list.Search(30));


            /*  Console.WriteLine("************");

              list.Add(56);
              Console.WriteLine("Node with data 56 is First Created");
              Console.WriteLine(" ");
              list.Add(30);
              Console.WriteLine("Next Append 70 to 56");
              Console.WriteLine(" ");
              list.Add(70);
              Console.WriteLine("Finally Append 70 to 30");
              Console.WriteLine(" ");
              Console.WriteLine("LinkedList Sequence:");

              list.Display();*/

            list.DeleteLast();
            Console.WriteLine("After delete Last element ");
            Console.WriteLine("LinkedList Sequence:");
            list.Display();





        }
        }
}
