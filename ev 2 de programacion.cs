using System;

namespace ev_2_de_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
             string cadena ="";
            int edad = 0;
            double altura = 0.0;
            
            
            Console.WriteLine("buenas tardes y mucho gusto, por favor ingrese su edad:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            
            
            if(edad >= 18)
            {
                Console.WriteLine("lo sentimos, estas instalaciones son para menores de 18 años.");
            } 
           else
            {
                Console.WriteLine("Bienvenido a mundo aventura");
                Console.WriteLine("Me podria decir su altura para indicarle a donde puede ir?");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);

                if(altura < 1.6)
                {
                    Console.WriteLine("solo puedes ir a el gusanito y al carrusel por nuestras medidas de seguridad y prevencion");
                  } 
                  else
                  {   
                      Console.WriteLine("tienes disponibles todas las atracciones del parque menos el carrucel que es para los mas chiquitos,");
                    }   
                    Console.WriteLine("Disfruten su paseo por nuestras instalaciones, tengan un gran de en mundo aventura!");
                    {
            } 
                        
                
             
            }
           
        }
    }
}
