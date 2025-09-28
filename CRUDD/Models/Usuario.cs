using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDD.Models
{
    internal class Usuario
    {
        // Properties
        private string username;
        private string foto;
        private string email;
        private string biografia;
        private string url;

        // Metodos Getters y Setters
        public string Username { get => username; set => username = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Email { get => email; set => email = value; }
        public string Biografia { get => biografia; set => biografia = value; }
        public string Url { get => url; set => url = value; }

        // Constructor

        public Usuario(string username)
        {
            this.username = username;
        }
        // Metodo para mostrar la informacion del usuario
        public void MostrarInfo()
        {
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Biografia: {biografia}");
            Console.WriteLine($"Url: {url}");
        }
    }

}
