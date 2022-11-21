﻿using System;
using System.Collections.Generic;

namespace LinkedListProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool condition = true;
            Console.WriteLine("Welcome to Linked List problem Statement");
            while (condition)
            {
                LinkedList linkedList = new LinkedList();
                Console.WriteLine("1. Create Linked List\n2. Create LinkedList in Reverse Order\n3. Inserting Data between 56 and 70" +
                                   "\n4. Remove the first Node from the Linked List\n5. Exit");
                Console.WriteLine("Enter your choice\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display(); // 56, 30, 70 - Same Order
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        linkedList.AddInReverseOrder(70);
                        linkedList.AddInReverseOrder(30);
                        linkedList.AddInReverseOrder(56);
                        linkedList.Display(); // 56, 30, 70 - reverse order printed
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        Console.WriteLine("Adding at position 1");
                        linkedList.InsertAtParticularPosition(1, 30);
                        linkedList.Display(); // 30 will be inserted between 56 % 70
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        linkedList.Display(); // 56 will be removed as it is first node
                        break;
                    default:
                        condition = false;
                        break;
                }
            }
        }
    }
}