using System;
 namespace Aporte{
     public class programs{
         static void Main(string[]args){

             gallina gallinita= new gallina("Floa", "cafe");
             Console.WriteLine("La gallina");
             Console.WriteLine("Su nombre es:"+ gallinita.nombre);
             Console.WriteLine("Es de color:"+ gallinita.color);
             Console.WriteLine("Es una ave domestica por lo tanto no vuela ni nada");
             Console.WriteLine("--------");

             condor condorito= new condor("Candy", "negro");
             Console.WriteLine("El condor");
             condorito.volar();
             Console.WriteLine("Su nombre es:"+ condorito.nombre);
             Console.WriteLine("Es de color:"+ condorito.color);
             Console.WriteLine("--------");

             pato patito= new pato ("Lucas", "blanco");
             Console.WriteLine("El pato");
             patito.volar();
             patito.nadar();
             Console.WriteLine("Su nombre es:"+ patito.nombre);
             Console.WriteLine("Es de color:"+ patito.color);


             }

         }
}
 