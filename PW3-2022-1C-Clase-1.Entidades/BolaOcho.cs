using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class BolaOcho
    {
        public static String Preguntar()
        {
            Random r = new Random();
            int codrta = r.Next(1, 21);
            string rta = "";

            switch (codrta)
            {
                case 1: rta = "Es cierto.";
                        break;
                case 2:
                    rta = "Es decididamente así.";
                    break;
                case 3:
                    rta = "Sin lugar a dudas.";
                    break;
                case 4:
                    rta = "Sí, definitivamente.";
                    break;
                case 5:
                    rta = "Puedes confiar en ello.";
                    break;
                case 6:
                    rta = "Como yo lo veo, sí.";
                    break;
                case 7:
                    rta = "Lo más probable.";
                    break;
                case 8:
                    rta = "Perspectiva buena.";
                    break;
                case 9:
                    rta = "Sí.";
                    break;
                case 10:
                    rta = "Las señales apuntan a que sí.";
                    break;
                case 11:
                    rta = "Respuesta confusa, vuelve a intentarlo.";
                    break;
                case 12:
                    rta = "Vuelve a preguntar más tarde.";
                    break;
                case 13:
                    rta = "Mejor no decirte ahora.";
                    break;
                case 14:
                    rta = "No se puede predecir ahora.";
                    break;
                case 15:
                    rta = "Concéntrate y vuelve a preguntar.";
                    break;
                case 16:
                    rta = "No cuentes con ello.";
                    break;
                case 17:
                    rta = "Mi respuesta es no.";
                    break;
                case 18:
                    rta = "Mis fuentes dicen que no.";
                    break;
                case 19:
                    rta = "Las perspectivas no son muy buenas.";
                    break;
                case 20:
                    rta = "Muy dudoso.";
                    break;


            }
            return rta;
        }
    }
}
