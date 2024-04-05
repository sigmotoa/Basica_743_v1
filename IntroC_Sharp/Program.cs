// See https://aka.ms/new-console-template for more information

//Muestra el texto en pantalla
Console.WriteLine("Hello. Please type your name");

//Crea una variable llamada name y la llena con el texto capturado del teclado por la consola
string name = Console.ReadLine();

//Console.WriteLine(name);
Console.WriteLine($"Welcome to the class {name}");
Console.WriteLine("Type your age");

//string age = Console.ReadLine();
int age = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"You have born in {2024-age}");

Console.WriteLine($"{name} por favor ingrese la nota del corte 1");
decimal nota_1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"{name} por favor ingrese la nota del corte 2");
int nota_2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"{name} por favor ingrese la nota del corte 3");
int nota_3 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"{name} su promedio es: {Convert.ToDecimal(nota_1+nota_2+nota_3)/3}");

/*
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());

name = name.ToUpper();

Console.WriteLine(name);*/