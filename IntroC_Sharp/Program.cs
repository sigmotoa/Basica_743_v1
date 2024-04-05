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

/*
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());

name = name.ToUpper();

Console.WriteLine(name);*/