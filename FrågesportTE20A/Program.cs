using System;

string name = "Johan"; 

Console.WriteLine("Hej välkommen till Johan Emsgård's Frågesport");

int points = 1; 


Console.WriteLine($"Points: {points}");
Console.WriteLine("Vad heter Nitendos Mascott?");  
string answer = Console.ReadLine(); 

if (answer == "Mario")
{
    Console.WriteLine("Correct"); 
    points++;
}

else 
{
    Console.WriteLine("Wrong"); 
}

Console.WriteLine($"points: {points}");
Console.WriteLine("What does CPU stand for?"); 
answer = Console.ReadLine(); 

if (answer == "Central Proccessing Unite") 
{
    Console.WriteLine("Correct");
    points++; 
}

else 
{
    Console.WriteLine("Wrong");
}

Console.WriteLine($"points: {points}");
Console.WriteLine("When did the first computer come out?");
Console.WriteLine("a) 1943");
Console.WriteLine("b) 1999");
Console.WriteLine("c) 1869");
answer = Console.ReadLine(); 

if ( answer == "1943")
{
    Console.WriteLine("Correct"); 
    points++; 
}

else 
{
    Console.WriteLine("Wrong");
}



Console.ReadLine(); 