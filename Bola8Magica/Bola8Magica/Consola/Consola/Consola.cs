namespace Consola
{
    public class Consola
    {
        static void Main(String[] args)
        {
            Bola8Magica bola8Magica = new Bola8Magica();
            Console.WriteLine($"La frase que te toco es : {bola8Magica.jugar()}");
        }
    }
}