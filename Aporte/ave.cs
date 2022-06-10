using System;
public class ave
{
    public string nombre {get; set;}
    public string color {get; set;}

    public ave(string nombre, string color)
    {
        this.nombre=nombre;
        this.color=color;
    }

    public void nadar(){
       Console.WriteLine("Esta ave nada");
    }

    public void volar(){
        Console.WriteLine("Esta ave vuela");

    }


}