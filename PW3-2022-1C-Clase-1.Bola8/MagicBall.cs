using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaMagica.Clases
{
    public static class MagicBall
    {

        private static List<Answer> _Respuestas = new List<Answer>()
        {
            new Answer() { Id =1, Message="Es cierto." },
            new Answer() { Id =2, Message="Es decididamente así."},
            new Answer() { Id =3, Message="Sin lugar a dudas."},
            new Answer() { Id =4, Message="Sí, definitivamente."},
            new Answer() { Id =5, Message="Puedes confiar en ello."},
            new Answer() { Id =6, Message="Como yo lo veo, sí."},
            new Answer() { Id =7, Message="Lo más probable."},
            new Answer() { Id =8, Message="Perspectiva buena."},
            new Answer() { Id =9, Message="Las señales apuntan a que sí."},
            new Answer() { Id =10, Message="Respuesta confusa, vuelve a intentarlo."},
            new Answer() { Id =11, Message="Vuelve a preguntar más tarde."},
            new Answer() { Id =12, Message="Mejor no decirte ahora."},
            new Answer() { Id =13, Message="No se puede predecir ahora."},
            new Answer() { Id =14, Message="Concéntrate y vuelve a preguntar."},
            new Answer() { Id =15, Message="No cuentes con ello."},
            new Answer() { Id =16, Message="Mi respuesta es no."},
            new Answer() { Id =17, Message="Mis fuentes dicen que no."},
            new Answer() { Id =18, Message="Las perspectivas no son muy buenas."},
            new Answer() { Id =19, Message="Si"},
            new Answer() { Id =20, Message="Muy dudoso."},

         };

        public static IEnumerable<Answer> Get() => _Respuestas;

        public static string GetRespuesta() => _Respuestas.FirstOrDefault(rec => rec.Id == new Random().Next(1, 20)).Message;   

    }
}
