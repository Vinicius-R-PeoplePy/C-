using System;

class Televisao
{
    // Properties
    public bool Ligada { get; set; }
    public int Canal { get; set; }

    // Constructor 
    public Televisao()
    {
        Ligada = false;
        Canal = 2;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Televisao class
        Televisao tv = new Televisao();

        // Print the properties of the tv object
        Console.WriteLine(tv.Ligada);
        Console.WriteLine(tv.Canal);

        // Create another instance of the Televisao class
        Televisao tvSala = new Televisao();

        // Modify the properties of the tvSala object
        tvSala.Ligada = true;
        tvSala.Canal = 4;

        // Print the properties of both objects
        Console.WriteLine(tv.Canal);
        Console.WriteLine(tvSala.Canal);
    }
}
