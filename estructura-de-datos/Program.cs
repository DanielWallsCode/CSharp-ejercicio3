
// !Ejercicio
public struct Client 
{
    public Client(string name, int number, string address, string email, bool newClient)
    {
        name = name;
        number = number;
        address = address;
        email = email;
        newClient = newClient;
    }

    public string name {get; set;}
    public int number {get; set;}
    public string address {get; set;}
    public string email {get; set;}
    public bool newClient {get; set;}


}




// Coords misCoordenadas = new Coords(2,10,0);
// Console.WriteLine("x: " + misCoordenadas.X);
// Console.WriteLine("y: " + misCoordenadas.Y);
// Console.WriteLine("z: " + misCoordenadas.Z);

// Coords misCoordenadas2 = misCoordenadas with { X = 3 };
// Console.WriteLine(misCoordenadas2);

// public struct Coords
// {
//  public Coords(double x, double y, double z)
//  {
//     X = x;
//     Y = y;
//     Z = z;
//     // t
//  }   

//  public double X { get; set; }
//  public double Y { get; set; }
//  public double Z { get; set; }


//  public override string ToString() => $"({X}, {Y}, {Z})";
// }