using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class Respuestas
    {
        public static string Respuesta()
        {
            Random random = new Random();   
            int caso = random.Next(0,19);
            string respuesta = "";
            switch (caso)
            {
                case 0: respuesta = " Es cierto.";
                    break;
                case 1: respuesta = " Es decididamente así";
                    break;
                case 2: respuesta = " Sin lugar a dudas.";
                    break;
                case 3: respuesta = " Sí, definitivamente.";
                    break;
                case 4: respuesta = "Puedes confiar en ello.";
                    break;
                case 5: respuesta = " Como yo lo veo, sí.";
                    break;
                case 6: respuesta = " Lo más probable.";
                    break;
                case 7: respuesta =  "  Perspectiva buena.";
                    break;
                case 8: respuesta =  "  Sí.";
                    break;
                case 9: respuesta =  " Las señales apuntan a que sí.";
                    break;
                case 10: respuesta =  " Respuesta confusa, vuelve a intentarlo.";
                    break;
                case 11: respuesta =  " Vuelve a preguntar más tarde.";
                    break;
                case 12: respuesta =  " Mejor no decirte ahora.";
                    break;
                case 13: respuesta =  "No se puede predecir ahora.";
                    break;
                case 14: respuesta =  "Concéntrate y vuelve a preguntar.";
                    break;
                case 15: respuesta =  "No cuentes con ello.";
                    break;
                case 16: respuesta =  "Mi respuesta es no.";
                    break;
                case 17: respuesta =  "Mis fuentes dicen que no";
                    break;
                case 18: respuesta =  "Las perspectivas no son muy buenas.";
                    break;
                case 19: respuesta =  "Muy dudoso. ";
                    break;
            }

            return respuesta;
        }
    }
}
