using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_25_09.modelos
{
    class UsuarioPremium : Usuario
    {
        public int Nivel_de_Membreesia;


        public override void RegistrarUsuario()
        {
              base.RegistrarUsuario();
              Console.WriteLine("Ingrese el nivel de membresia que tiene actualmente");
              Nivel_de_Membreesia = int.Parse(Console.ReadLine());
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine("Nivel de Membresía Premium: " + Nivel_de_Membreesia); 
        }

        public override void ActualizarEmail()
        {
              base.ActualizarEmail();
        }
    }
}
