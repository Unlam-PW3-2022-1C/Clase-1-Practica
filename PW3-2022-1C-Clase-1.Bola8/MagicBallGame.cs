using BolaMagica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaMagica.ClasesBolaMagica
{
    public class MagicBallGame
    {

        public void Jugar()
        {
            Console.WriteLine("Magic Ball!");

            Console.WriteLine("Pregunta y responderé: ");

            string Pregunta = Console.ReadLine();

            Console.WriteLine($"{MagicBall.GetRespuesta()}");

            Console.ReadKey();
        }

    }
}
