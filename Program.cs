﻿using System.Xml.Linq;

Console.WriteLine("1 Oldest Siblings");

Console.WriteLine("Welcome to the Oldest Sibling Application.");

Console.WriteLine("This application will tell us who the oldest of a pair of siblings is.");



 
Console.WriteLine("First sibling, what is your name?");

string name1 = Console.ReadLine();

Console.WriteLine("Hello " + name1 + ", How old are you?");

int age1 = int.Parse(Console.ReadLine());

Console.WriteLine("Second sibling, what is your name?");
string name2 = Console.ReadLine();

Console.WriteLine("Hello " + name2 + ", How old are you?");
int age2 = int.Parse(Console.ReadLine());



if (age1 > age2)
{
    Console.WriteLine(name1 + " is " + (age1 - age2) + " years older than " + name2);
}

