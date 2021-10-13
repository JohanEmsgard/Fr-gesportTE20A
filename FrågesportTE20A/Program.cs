using System;

Console.WriteLine("Hej välkommen till Frågesport 2021 vad heter du?");
string name = Console.ReadLine(); 

Console.WriteLine($"Hej {name}"); 

int points = 0; 

Console.WriteLine($"Points: {points}");
Console.WriteLine("Vad heter Nitendos Mascott?");  
Console.WriteLine("a) Mario");
Console.WriteLine("b) Sonic");
Console.WriteLine("c) Pikachu");
Console.WriteLine("d) Megaman");
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

if (answer == "Central Proccessing Unit") 
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

Console.WriteLine($"grattis du fick {points} poäng!"); 

Console.ReadLine(); 