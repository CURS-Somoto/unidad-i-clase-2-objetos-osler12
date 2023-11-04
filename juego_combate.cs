sing System;

class Personaje
{
    private string nombre;
    private string arma;
    private string tipo;

    public string Nombre
    {
        get { return nombre; }
    }

    public string Arma
    {
        get { return arma; }
    }

    public string Tipo
    {
        get { return tipo; }
    }

    public Personaje(string nombre, string arma, string tipo)
    {
        this.nombre = nombre;
        this.arma = arma;
        this.tipo = tipo;
    }

    public void Atacar()
    {
        Console.WriteLine("El personaje {0} ataca con {1}!", Nombre, Arma);
    }

    public void Correr()
    {
        Console.WriteLine("El personaje {0} griata aaaa y tira el primer ataque!", Nombre);
    }
    public void Tumba()
    {
        Console.WriteLine("El personaje {0} Tumba a su oponente Muerte Muerte !", Nombre);

    }
    public void defender()
    {
        Console.WriteLine("El personaje {0} se está defendiendo!", Nombre); 
    }
             public void bloquear()
    {
        Console.WriteLine("El personaje {0} bloquea el ataque!", Nombre);
             }
              public void cae()
              {
               Console.WriteLine("El personaje {0} Cae al piso luego piensa en uan mejor estratejia!", Nombre);
              }
              public void Sonrrie()
              {
                  Console.WriteLine("El personaje {0} Sonrrie maleficamente por tumbar a su oponente Muerte !", Nombre);
                   }
              public void Levanta()
              {
                  Console.WriteLine("El personaje {0} Se levanta asombrosamente Con mas furia para atacar!", Nombre);
                   }
              public void Asombrado()
              {
                  Console.WriteLine("El personaje {0} Se asombra por la recuperacion de Muerte !", Nombre);
                   }
              public void Ataca()
              {
                  Console.WriteLine("El personaje {0} Ataca y clava su espada mortal en el corazón de Zeus !", Nombre);
                  }
              public void Cae()
              {
                  Console.WriteLine("El personaje {0} Cae derrotado!", Nombre);
                   }
              public void Logra()
              {
                  Console.WriteLine("El personaje {0} Logra derrotar a Zeus!", Nombre);
                  }
              public void Ganador()
              {
                  Console.WriteLine("El personaje {0} Es el ganador fin del juego !", Nombre);


    }
}

class Program
{
    static void Main(string[] args)
    {
        Personaje Zeus = new Personaje("Zeus", "Hacha gigante", "Tanque");

        Console.WriteLine("Informacion del personaje 1");
        Console.WriteLine("Nombre: {0}", Zeus.Nombre);
        Console.WriteLine("Arma: {0}", Zeus.Arma);
        Console.WriteLine("Tipo: {0}", Zeus.Tipo);
        Zeus.Atacar();
        Zeus.Correr();
        Zeus.Tumba();
        Zeus.Sonrrie();
        Zeus.Asombrado();
        Zeus.Cae();
       
        Console.WriteLine();

        Personaje Muerte = new Personaje("Muerte ", "Espada doble", "Filo mortal");

        Console.WriteLine("Informacion del personaje 2");
        Console.WriteLine("Nombre: {0}", Muerte.Nombre);
        Console.WriteLine("Arma: {0}", Muerte.Arma);
        Console.WriteLine("Tipo: {0}", Muerte.Tipo);
        Console.WriteLine("Acciones del personaje");
        Muerte.defender();
        Muerte.bloquear();
        Muerte.cae();
        Muerte.Levanta();
        Muerte.Ataca();
        Muerte.Logra();
        Console.WriteLine();
        Console.WriteLine();
        Muerte.Ganador();

        Console.ReadLine();
    }
}

