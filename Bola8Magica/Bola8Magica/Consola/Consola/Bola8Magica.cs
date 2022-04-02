using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Bola8Magica
    {
        List<String> listadoDeFrases;
        public Bola8Magica()
        {
            this.listadoDeFrases = setRespuestas();
        }

        private List<String> setRespuestas()
        {
            List<String> list = new List<String>();
            list.Add("Es cierto");
            list.Add("Es decididamente así");
            list.Add("Sin lugar a dudas");
            list.Add("Sí, definitivamente");
            list.Add("Puedes confiar en ello");
            list.Add("Como yo lo veo, sí");
            list.Add("Lo más probable");
            list.Add("Perspectiva buena");
            list.Add("Si");
            list.Add("Las señales apuntan a que sí");
            list.Add("Respuesta confusa, vuelve a intentarlo");
            list.Add("Vuelve a preguntar más tarde");
            list.Add("Mejor no decirte ahora");
            list.Add("No se puede predecir ahora");
            list.Add("Concéntrate y vuelve a preguntar");
            list.Add("No cuentes con ello");
            list.Add("Mi respuesta es no");
            list.Add("Mis fuentes dicen que no");
            list.Add("Las perspectivas no son muy buenas");
            list.Add("Muy dudoso");
            return list;
        }

        public String jugar()
        {
            Random random = new Random();
            int value = random.Next(0, listadoDeFrases.Count);
            return this.listadoDeFrases[value];
        }
    }
}
