using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace HelloWorld;

class Program
{
    static void Main()

    {
        //Inserir dados
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine($"Hello, {nome}! Welcome!");

        Console.WriteLine();
        Console.WriteLine();

        //Comcatenação
        Console.WriteLine("Digite seu primeiro nome:");
        string nome2 = Console.ReadLine();
        Console.WriteLine("Digite seu Sobrenome:");
        string sobrenome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Primeiro nome: {nome2}");
        Console.WriteLine($"Sobrenome: {sobrenome}");
        Console.WriteLine($"Nome completo:{nome2 + " " + sobrenome}");

        Console.WriteLine();
        Console.WriteLine();

        //Double
        Console.WriteLine("Insira o primeiro valor");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o primeiro valor");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Soma dos valores: {x + y}");
        Console.WriteLine($"Subtração dos valores: {x - y}");
        Console.WriteLine($"Multiplicação dos valores: {x * y}");
        Console.WriteLine($"Divisão dos valores: {x / y}");

        Console.WriteLine();
        Console.WriteLine();

        //Caracteres
        Console.WriteLine("Insira sua frase:");
        string frase = Console.ReadLine();
        int numeroDeCaracteres = frase.Replace(" ", "").Length;

        Console.WriteLine("Quantidade de caracteres na frase:" + " " + numeroDeCaracteres);

        Console.WriteLine();
        Console.WriteLine();

        //Data Atual

        DateTime dataagora = DateTime.Now;

        string dataCompleta = dataagora.ToString("dddd,dd MMMM, yyyy  hh:mm:ss tt");
        string dataFormatada = dataagora.ToString("dd/MM/yyyy");
        string horaFormatada = dataagora.ToString("HH");
        String dataExtesno = dataagora.ToString("dd/MMMM/yyyy");


        Console.WriteLine(dataCompleta);

    }
}

