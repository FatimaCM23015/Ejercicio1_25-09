using Ejercicio1_25_09.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_25_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            
            Usuario usuario = new Usuario();
            UsuarioPremium usuarioPremium = new UsuarioPremium();

            //usuario.RegistrarUsuario();
            Console.WriteLine("¿Desea registrar un usuario premium? \n Presione \"1\" para Sí \n Presione cualquier otro número para No");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion) 
            {
                case 1:
                    {
                        usuarioPremium.RegistrarUsuario();
                        usuarioPremium.ActualizarEmail();
                        usuarioPremium.MostrarDetalles();
                        
                        break;
                    }
                default:
                    {
                       usuario.RegistrarUsuario();
                       usuario.ActualizarEmail();
                       usuario.MostrarDetalles();
                        break;
                    }
            }

            

        }
    }
}
