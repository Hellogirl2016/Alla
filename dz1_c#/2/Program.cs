﻿//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine( "Insert, please, first number" );
int num1 = Convert.ToInt32(System.Console.ReadLine( ));
System.Console.WriteLine( "Insert, please, second number" );
int num2 = Convert.ToInt32(System.Console.ReadLine( ));

int max = num1;

if (num2 > max)
max = num2;

Console.WriteLine($"Maximal number between {num1} and {num2} is {max}");

