using CRUDD.Models;
using CRUDD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CRUDD
{
    internal class UsuarioCRUD
    {
        // Atributos
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private MensajeUI mensaje = new MensajeUI(50);

        // constructor
        public UsuarioCRUD()
        {
            Usuario usuarioPrueba = new Usuario("ecaceres");
            listaUsuarios.Add(usuarioPrueba);
        }
        // Metodos
        public void MostrarUsuarios()
        {
            mensaje.MostrarTitulo("RELACIÓN DE USUARIOS GITHUB");
            foreach (var usuario in listaUsuarios)
            {
                Console.WriteLine(new string('*',50));
                usuario.MostrarInfo();               
            }
        }

        public void RegistrarUsuario()
        {
            mensaje.MostrarTitulo("REGISTRO DE NUEVO USUARIO");
            Console.Write("USERNAME : ");
            string username = Console.ReadLine();

            Usuario nuevoUsuario = new Usuario(username);
            Console.Write("EMAIL : ");
            nuevoUsuario.Email = Console.ReadLine();
            Console.Write("FOTO : ");
            nuevoUsuario.Foto = Console.ReadLine();
            Console.Write("BIOGRAFIA : ");
            nuevoUsuario.Biografia = Console.ReadLine();
            Console.Write("URL : ");
            nuevoUsuario.Url = Console.ReadLine();
            listaUsuarios.Add(nuevoUsuario);
            mensaje.MostrarMensaje("Usuario registrado con exito");
        }


    }
}
