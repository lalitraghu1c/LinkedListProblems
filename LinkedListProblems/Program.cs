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
                Console.WriteLine("1. Create Linked List\n2. Create LinkedList in Reverse Order\n3. Exit");
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
                    default:
                        condition = false;
                        break;
                }
            }
        }
    }
}