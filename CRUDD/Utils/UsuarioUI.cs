using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDD.Utils
{
    internal class UsuarioUI
    {
        // Atributos
        const int ANCHO = 50;
        private UsuarioCRUD crud;
        private MensajeUI mensaje = new MensajeUI(ANCHO);

        // Constructor

        public UsuarioUI()
        {
            this.crud = new UsuarioCRUD();
        }

        // Metodos

        public void MostrarMenu()
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.Clear();
                mensaje.MostrarTitulo("CRUD DE USUARIOS GITHUB");
                Console.WriteLine(@"
                [1] REGISTRAR USUARIO
                [2] MOSTRAR USUARIOS
                [3] ACTUALIZAR USUARIOS
                [4] ELIMINAR USUARIO
                [5] SALIR
                ");
                Console.Write("INGRESE UNA OPCIÓN [1-5]: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        crud.RegistrarUsuario();
                        break;
                    case 2:
                        crud.MostrarUsuarios();
                        Console.WriteLine("Pulse ENTER para continuar...");

                        Console.ReadLine();
                        break;
                    case 3:
                        mensaje.MostrarMensaje("OPCIÓN EN CONSTRUCCIÓN");
                        break;
                    case 4:
                        mensaje.MostrarMensaje("OPCIÓN EN CONSTRUCCIÓN");
                        break;
                    case 5:
                        mensaje.MostrarMensaje("SALIENDO DEL PROGRAMA");
                        break;
                    default:
                        mensaje.MostrarMensaje("OPCIÓN INCORRECTA");
                        break;
                }

            }    
        }
    }
}
