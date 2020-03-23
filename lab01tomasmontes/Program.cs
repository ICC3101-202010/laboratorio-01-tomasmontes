using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MainClass
{
    public static void Main(string[] args)
    {
        Random Aleatorio = new Random();
        int Numero;
        Numero = Aleatorio.Next(0, 3);
        
        
        Person p1 = new Person("Bob", "kunga");
        Console.WriteLine(p1.GetName());
        Console.WriteLine(p1.GetLastname());
        Console.WriteLine("el numero es");
        Console.WriteLine(Numero);

        Console.ReadKey();
    }

}

public class Person
{
    private string Name;
    private string Lastname;

  //constructor   
    public Person(string Name, string Lastname)
    {
        this.Name = Name;
        this.Lastname = Lastname;
    }

    public void Lanzar()
    {
        Random Aleatorio = new Random();
        int Numero;
        Numero = Aleatorio.Next(0, 3);
    }
   
    public string GetName()
    {
        return Name;
    }

    public string GetLastname()
    {
        return Lastname;
    }

  
}


