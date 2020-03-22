using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01tomasmontes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

public class Person
{
    private string Name;
    private string Lastname;

    public Person(string Name, string Lastname)
    {
        this.Name = Name;
        this.Lastname = Lastname;
    }

    public void Tirar()
    {
        Random Aleatorio = new Random();
        int Numero;
        Numero = Aleatorio.Next(0, 3);
        Console.WriteLine("el numero es:" + Numero);
    }
}

