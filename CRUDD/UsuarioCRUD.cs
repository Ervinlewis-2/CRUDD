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

        private Usuario BuscarUsuario(string opcion)
        {
            mensaje.MostrarTitulo($"{opcion} USUARIO");
            Console.Write("INGRESE USERNAME : ");
            string usuarioBusqueda = Console.ReadLine();

            Usuario usuario= listaUsuarios.Find(a => a.Username.Equals(usuarioBusqueda, StringComparison.OrdinalIgnoreCase));

            return usuario;
        }

        public void ActualizarUsuario()
        {
            Usuario usuarioActualizar = BuscarUsuario("ACTUALIZAR");
            if (usuarioActualizar != null)
            {
                Console.WriteLine("USUARIO ENCONTRADO : ");
                usuarioActualizar.MostrarInfo();
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("INGRESE LOS NUEVOS DATOS : ");
                Console.Write("EMAIL : ");
                usuarioActualizar.Email = Console.ReadLine();
                Console.Write("FOTO : ");
                usuarioActualizar.Foto = Console.ReadLine();
                Console.Write("BIOGRAFIA : ");
                usuarioActualizar.Biografia = Console.ReadLine();
                Console.Write("URL : ");
                usuarioActualizar.Url = Console.ReadLine();
                mensaje.MostrarMensaje("Usuario actualizado con exito");
            }
            else
            {
                mensaje.MostrarMensaje("USUARIO NO ENCONTRADO...");
            }
        }

        public void EliminarUsuario()
        {
            Usuario usuarioEliminar = BuscarUsuario("ELIMINAR");
            if (usuarioEliminar != null)
            {
                Console.WriteLine("USUARIO ENCONTRADO : ");
                usuarioEliminar.MostrarInfo();
                Console.WriteLine(new string('*', 50));
                Console.Write("DESEA ELIMINAR ESTE USUARIO? (S/N) : ");
                string opcion = Console.ReadLine().ToUpper();
                if (opcion == "S")
                {
                    listaUsuarios.Remove(usuarioEliminar);
                    mensaje.MostrarMensaje("USUARIO ELIMINADO CON EXITO");
                }
                else
                {
                    mensaje.MostrarMensaje("OPERACIÓN CANCELADA");
                }
            }
            else
            {
                mensaje.MostrarMensaje("USUARIO NO ENCONTRADO...");
            }
        }


    }
}
