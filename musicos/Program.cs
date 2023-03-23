abstract class Musico //Clase General, no tiene sentido crear un objeto, solo crea referencias.
{
    public string Nombre {get;set;}

    public Musico(string nombre)
    {
        Nombre=nombre;
    }

    public void Saludar()
    {
      Console.WriteLine($"Hola soy {Nombre}");
    }
    public /*virtual*/ abstract void Toca();
    /*{
        Console.WriteLine($"{Nombre} tocando un instrumento");
    }*/

}

class Baterista:Musico
{
    public string bateria{get;set;}

 public Baterista(string nombre, string b):base(nombre)
 {
    bateria=b;
 }
    public override void Toca()
    {
        Console.WriteLine($"Tocando su {bateria} el artista {Nombre}");
    }

}

class Bajista:Musico
{
 public string bajo{get;set;}

 public Bajista(string nombre, string b):base(nombre)
 {
    bajo=b;
 }
    public override void Toca()
    {
        Console.WriteLine($"Tocando su {bajo} el artista {Nombre}");
    }

}

class Program
{
    private static void Main(string[] args)
    {
        /*Musico EdSheeran = new Musico("EdSheeran");
        EdSheeran.Saludar();
        EdSheeran.Toca();*/

        List<Musico> grupo= new List<Musico>();
        grupo.Add(new Bajista("joe","Yamanaka"));
        grupo.Add(new Baterista("Eric","Mac"));
        /*grupo.Add(new Musico("EdSheeran"));*/

        foreach(var m in grupo)
        {
          m.Saludar();
        }
        foreach(var m in grupo)
        {
          m.Toca();
        }

    }
}