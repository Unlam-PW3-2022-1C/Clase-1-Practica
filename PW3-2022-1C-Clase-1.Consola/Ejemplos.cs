using PW3_2022_1C_Clase_1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2022_1C_Clase_1.Consola
{
    public static class Ejemplos
    {
        public static void calculadora()
        {
            Console.WriteLine("Bienvenido a la calculaddora!");
            Console.WriteLine("Ingrese los numeros a sumar");

            Console.WriteLine("Num 1: ");
            string num1 = Console.ReadLine();
            //if (!Int32.TryParse(num1, out int int3))
            //    Console.WriteLine("El numero ingresado es inválido");

            Console.WriteLine("Num 2: ");
            string num2 = Console.ReadLine();

            Console.WriteLine($"{num1} + {num2} = {Calculadora.Sumar(num1, num2)}");
            Console.ReadKey();

        }

        public static void bola8()
        {
            Console.WriteLine("Hazme una pregunta:");

            string pregunta = Console.ReadLine();

            Random rand = new Random();

            rand.Next(0, 19);

            List<string> respuesta = new List<string>();

            respuesta.Add("Es cierto.");
            respuesta.Add("Respuesta confusa, vuelve a intentarlo.");
            respuesta.Add("No cuentes con ello");

            Console.WriteLine(respuesta[rand.Next(0, 2)]);

        }
    }
}
