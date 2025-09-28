using CRUDD.Models;

namespace CRUDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Usuario usuaio = new Usuario("john_doe");
            usuaio.MostrarInfo();
        }
    }
}