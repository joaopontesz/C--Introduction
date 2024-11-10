# README - C# Console Application Example

This README explains the functionality of a simple C# console application that demonstrates various basic features like data input, string manipulation, arithmetic operations, character counting, and working with dates.

## Overview

The code contains a sequence of operations that:
1. Gathers input from the user.
2. Demonstrates string manipulation through concatenation and formatting.
3. Performs basic arithmetic operations on user input (double values).
4. Counts characters in a user-provided phrase, excluding spaces.
5. Displays the current date and time in various formats.

## Code Walkthrough

### 1. **User Input and Greeting**

```csharp
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Hello, {nome}! Welcome!");
```

- The program prompts the user to input their name.
- It then greets the user using the input name.

### 2. **Concatenation of First Name and Last Name**

```csharp
Console.WriteLine("Digite seu primeiro nome:");
string nome2 = Console.ReadLine();
Console.WriteLine("Digite seu Sobrenome:");
string sobrenome = Console.ReadLine();
Console.WriteLine();

Console.WriteLine($"Primeiro nome: {nome2}");
Console.WriteLine($"Sobrenome: {sobrenome}");
Console.WriteLine($"Nome completo:{nome2 + " " + sobrenome}");
```

- The user is asked to enter their first name and surname.
- The program outputs the first name, surname, and the full name (concatenated string).

### 3. **Arithmetic Operations on Double Values**

```csharp
Console.WriteLine("Insira o primeiro valor");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o segundo valor");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Soma dos valores: {x + y}");
Console.WriteLine($"Subtração dos valores: {x - y}");
Console.WriteLine($"Multiplicação dos valores: {x * y}");
Console.WriteLine($"Divisão dos valores: {x / y}");
```

- The program requests two numeric values from the user.
- It then performs and displays the results of the following arithmetic operations: addition, subtraction, multiplication, and division.

### 4. **Counting Characters in a Phrase (Excluding Spaces)**

```csharp
Console.WriteLine("Insira sua frase:");
string frase = Console.ReadLine();
int numeroDeCaracteres = frase.Replace(" ", "").Length;

Console.WriteLine("Quantidade de caracteres na frase:" + " " + numeroDeCaracteres);
```

- The user is prompted to input a phrase.
- The program removes all spaces from the input and counts the remaining characters, displaying the result.

### 5. **Displaying the Current Date and Time**

```csharp
DateTime dataagora = DateTime.Now;

string dataCompleta = dataagora.ToString("dddd,dd MMMM, yyyy  hh:mm:ss tt");
string dataFormatada = dataagora.ToString("dd/MM/yyyy");
string horaFormatada = dataagora.ToString("HH");
String dataExtesno = dataagora.ToString("dd/MMMM/yyyy");

Console.WriteLine(dataCompleta);
```

- The program retrieves the current date and time using `DateTime.Now`.
- It then formats the date and time into different styles, including the full date and time, short date, hour in 24-hour format, and a date with the full month name.
- The result is displayed in the console.

## Requirements

- .NET Framework or .NET Core (depending on your environment).
- Visual Studio or another IDE with C# support for running console applications.

## Conclusion

This simple application showcases basic operations such as taking user input, string manipulation, performing arithmetic calculations, counting characters, and working with dates and times in C#. It serves as a foundation for beginners to understand how to handle user input, work with strings, and manipulate numeric data in C#.
