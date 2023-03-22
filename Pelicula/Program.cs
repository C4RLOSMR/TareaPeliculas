using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo, director, pais;
        private Int16 año;


        public string GetTitulo(){return titulo;}
        public string GetDirector(){return director;}
        public string GetPais(){return pais;}
        public Int16 GetAño(){return año;}

        public void SetTitulo(string NuevoTitulo){titulo = NuevoTitulo;}
        public void SetDirector(string NuevoDirector){director = NuevoDirector;}
        public void SetPais(string NuevoPais){pais = NuevoPais;}
        public void SetAño(Int16 NuevoAño){año = NuevoAño;}

        public Pelicula()
        {

        }

        public Pelicula(String Titulo, Int16 Año)
        {
               titulo = Titulo;
               año = Año;
        }


        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades
       private string Nombre;
       private  Int16 Año;

        public string Getnombre(){return Nombre;}
        public Int16 Getaño(){return Año;}
        public void Setnombre(string Nuevonombre){Nombre = Nuevonombre;}
        public void SetAño(Int16 Nuevoaño){ Año = Nuevoaño;}

        //Constructores
        public Actor(string a, Int16 b)
        {
            Nombre = a;
            Año = b;
        }

        
        //Métodos 

        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula("THE GODFATHER", 1972);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            Pelicula p2 = new Pelicula("THE LORD OF THE RINGS: THE RETURN OF THE KING", 2003);
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine();

            var peliculas = new List<string>();
            peliculas.Add("Harry Potter and the Prisoner of Azkaban");
            peliculas.Add("Fight Club");
            peliculas.Add("Crossroads");
            peliculas.Add("Reservoir Dogs");
            peliculas.Add("Blade Runner 2049");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(var pelicula in peliculas)
            {
                Console.WriteLine(pelicula.ToUpper());
            }
            Console.ForegroundColor = ConsoleColor.White;
        }  
    } 
}
