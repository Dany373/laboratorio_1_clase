using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProgra1.Laboratorio;

namespace LaboratorioProgra1.listaDeJuegos
{
    class JuegoDeAccion : VideoJuego
    {
        private string nivelDificultad;
        private string armaActual;
        private int puntos;
        private int vecesCorrer;
        public string invitado;

        public string NivelDificultad
        {
            get { return nivelDificultad; }
            set { nivelDificultad = value; }
        }

        public string ArmaActual
        {
            get { return armaActual; }
            set { armaActual = value; }
        }

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        public int VecesCorrer
        {
            get { return vecesCorrer; }
            set { vecesCorrer = value; }
        }
        public void SeleccionarDificultad(string dificultad)
        {
            NivelDificultad = dificultad;
            Console.WriteLine("Dificultad seleccionada: " + dificultad);
        }

        public void SeleccionarArma(string arma)
        {
            ArmaActual = arma;
            Console.WriteLine("Arma seleccionada: " + arma);
        }
        public void IniciarPartida()
        {
            Puntos = 5; // Se establecen los puntos de vida al iniciar el juego
            VecesCorrer = 0;
            Console.WriteLine("\t¡Juego iniciado!");

            while (Puntos > 0)
            {
                Console.WriteLine("\n¿Qué deseas hacer? (1. Atacar, 2. Correr, 3. Abandonar la Partida)");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("¡Has decidido atacar!");
                    Atacar();
                }
                else if (opcion == 2)
                {
                    if (VecesCorrer < 2)
                    {
                        Console.WriteLine("\nEstás corriendo, pero... ¡adelante un nuevo enemigo! ¿Qué harás?");
                        VecesCorrer++;
                    }
                    else
                    {
                        Console.WriteLine("¡Has corrido demasiado! No puedes correr más.");
                    }
                }
                else if (opcion == 3)
                {
                    Puntos = 0;
                    Console.WriteLine("Haz Abandonado la Partida, te corriste :(");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }

            Console.WriteLine("\n¡Haz perdido la partida! Tus puntos han llegado a cero.");
        }
        private void Atacar()
        {
            Console.WriteLine("Elige un número 1 o 2:");
            int numeroElegido = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(1, 3);

            if (numeroElegido == numeroAleatorio)
            {
                Console.WriteLine("¡Ataque efectivo! Ganaste 2 puntos.");
                Puntos += 2;
            }
            else
            {
                Console.WriteLine("¡Haz fallado el ataque! Tu enemigo acertó. Pierdes 2 puntos.");
                Puntos -= 2;
            }

            if (Puntos >= 10)
            {
                Console.WriteLine("¡Has ganado el juego! ¡Felicidades!");
            }
        }
    }

}