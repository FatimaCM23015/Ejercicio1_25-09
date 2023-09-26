using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_25_09.modelos
{
    class Usuario
    {
        public string UserName;
        public string Password;
        public string Email;


        public virtual void RegistrarUsuario()
        {
            Console.WriteLine("Ingrese los datos del usuario a registrar");
            Console.WriteLine("Ingrese el username");
            this.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña");
            this.Password = Console.ReadLine();
            Console.WriteLine("Ingrese el email");
            this.Email = Console.ReadLine();
        }

        public virtual void MostrarDetalles()
        {
            Console.Clear();
            Console.WriteLine("DATOS DEL USUARIO RECIEN REGISTRADO");
            Console.WriteLine($"Username: {UserName}");
            Console.WriteLine($"Contraseña: {Password}");
            Console.WriteLine($"Email: {Email}");
        }

        public virtual void ActualizarEmail()
        {
            int opcion1;
            string newEmail;
            Console.WriteLine("¿Desea modificar el email? \n Presione \"1\" para Sí \n Presione cualquier otro número para No");
            opcion1 = int.Parse(Console.ReadLine());

           if(opcion1 == 1)
            {
                Console.WriteLine("Ingrese el nuevo correo");
                newEmail = Console.ReadLine();

                Email = newEmail;
            }
            
            
            
        }

        

    }
}
