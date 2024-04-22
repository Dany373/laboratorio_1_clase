using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.EjemploPolimorfismo.Heredados
{
    internal class Tortuga: Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("La tortuga hace tuctuctictuctuc");
        }
    }
}
