using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Tipos_juego
{
    internal class tirosPenales
    {
        public string EquipoLocal { get; set; }

        public string EquipoVisitante { get; set; }
        public int GolesLocal { get; private set; }
        public int GolesVisitante { get; private set; }
        public int IntentosLocal { get; private set; }
        public int IntentosVisitante { get; private set; }


        public tirosPenales(string titulo, string desarrolladora, int calificacion, int anioLanzamiento,
                            string equipoLocal, string equipoVisitante)

        {
            this.EquipoLocal = equipoLocal;
            this.EquipoVisitante = equipoVisitante;

        }

        public void TirarPenalLocal()
        {
            Random random = new Random();
            bool gol = random.Next(2) == 0; // 50% de probabilidad de gol
            if (gol)
            {
                RegistrarGolLocal();
            }
            else
            {
                Console.WriteLine("¡El penal ha sido atajado por el portero!");
            }
            IntentosLocal++;
        }

        public void TirarPenalVisitante()
        {
            Random random = new Random();
            bool gol = random.Next(2) == 0; // 50% de probabilidad de gol
            if (gol)
            {
                RegistrarGolVisitante();
            }
            else
            {
                Console.WriteLine("¡El penal ha sido atajado por el portero!");
            }
            IntentosVisitante++;
        }

        public void AtajarPenal()
        {
            Random random = new Random();
            int posicionPortero = random.Next(5); // Posiciones de 0 a 4
            int posicionTirada = random.Next(5); // Posiciones de 0 a 4
            if (posicionPortero == posicionTirada)
            {
                Console.WriteLine("¡El portero ha atajado el penal!");
            }
            else
            {
                Console.WriteLine("¡El penal ha sido gol!");
            }
        }

        public void RegistrarGolLocal()
        {
            GolesLocal++;
            Console.WriteLine("Gol equipo Local");
        }

        public void RegistrarGolVisitante()
        {
            GolesVisitante++;
            Console.WriteLine("Gol visitante");
        }

        public void IniciarPartida()
        {
            Console.WriteLine($"Comienza la tanda de penales entre {EquipoLocal} y {EquipoVisitante}.");
        }

        public void DetenerPartida()
        {
            Console.WriteLine("Se ha terminado la tanda de penales.");
        }

        public void MostrarResultado()
        {
            Console.WriteLine($"Resultado final: {EquipoLocal} {GolesLocal} - {GolesVisitante} {EquipoVisitante}");
        }
    }
}
