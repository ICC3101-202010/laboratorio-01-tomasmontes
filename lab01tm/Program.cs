public class Person
{
    private string name;
    private string lastname;

    public Person(string name, string lastname)
    {
        this.name = name;
        this.lastname = lastname;
    }

    public void tirar()
    {
        Random aleatorio = new Random();
        int numero;
        numero = aleatorio.next(0, 3);
        Console.WriteLine(" el numero es" + numero);
    }
}