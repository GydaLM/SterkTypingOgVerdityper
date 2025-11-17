// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

int tall = 4;
long langtTall = 50500l;
float desimalTall = 3.314f; //mindre enn double, krever mindre (mindre plass)
decimal mangeDesimaler = 3.1415926536m; //større enn double (mer bytes)
double desimalTall2 = 3.141; //default så trenger ikke d bak (mellom float og decimal, tar litt mer plass enn float)

string text = "This is a text";
char character = 'a';
bool thisIsTrue = true;

int a = 5;
decimal b = 3m;
decimal sum = a + b;

Console.WriteLine($"Resultat: {sum}");