using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDD.Utils
{
    internal class MensajeUI
    {
        // Atributos
        private int ancho = 50;
        // Constructor

        public MensajeUI(int ancho)
        {
            this.ancho = ancho;
        }
        // Metodos
        public void MostrarTitulo(string titulo)
        {
            Console.WriteLine(new string('*', ancho));
            Console.WriteLine(new string(' ', 15) + titulo);
            Console.WriteLine(new string('*', ancho));
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(new string('*', ancho));
            Console.WriteLine(new string (' ',15)+ mensaje);
            Console.WriteLine(new string('*', ancho));
            System.Threading.Thread.Sleep(1000);
        }
    }
}
