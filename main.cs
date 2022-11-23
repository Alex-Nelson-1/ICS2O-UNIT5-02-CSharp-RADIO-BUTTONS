// Created by: Alex Nelson
// Created on: Nov 2022
//
// This program will generate a random positive or negative integer for you
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Input
        string posNegValue = "P" ;
        //Returns an `int` value greater in the range 1 <= value <7
        Random rd = new Random();
        int randomNumber = rd.Next(1, 7);
        Console.WriteLine("This program will generate a positive or negative integer from 1-6");
        Console.WriteLine("");
        Console.WriteLine("Type P for a postive integer and N for a negative integer");
        posNegValue = (Console.ReadLine());
        //Output
        Console.WriteLine("");
        if (posNegValue == "P")
        {
            Console.WriteLine("Here is your positve integer: " + randomNumber);
        }
        else
        {
            Console.WriteLine("Here is your negative integer: " + randomNumber * -1);
        }
        Console.WriteLine("\nDone");
    }
}