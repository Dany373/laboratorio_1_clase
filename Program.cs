using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.listaDeJuegos;
using LaboratorioProgra1.Tipos_juego;
using System;
using System.Security.Cryptography.X509Certificates;




while (true)
{
    Console.WriteLine("Bienvenido a la selección de juegos:\n");

    Console.WriteLine("1. Tiros Penales");
    Console.WriteLine("2. Corre y Ataca");
    Console.WriteLine("3. Salir de los Juegos");
    Console.WriteLine("\nElija una opción:\n");

    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Juego1();
            break;
        case 2:
            Juego2();
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Opción no válida.\n");
            break;
    }
}


void Juego1()
{
    VideoJuego.saludo();
    tirosPenales Penales = new tirosPenales("Futbol penales", "EA Sports", (int)4.5, 2024, "Equpo Local", "Equipo Visitante");

    // Iniciar las partidas
    Penales.IniciarPartida();
    Penales.TirarPenalLocal();
    Penales.AtajarPenal();
    Penales.TirarPenalVisitante();
    Penales.MostrarResultado();
}

void Juego2()
{
    VideoJuego.saludo();
    JuegoDeAccion juego = new JuegoDeAccion();
    bool juegoIniciado = false;
    juego.Titulo = "Corre y Ataca";
    juego.Desarrolladora = "Marlon Y Dany Company";
    juego.Calificacion = 5;
    juego.AnioLanzamiento = 2024;
    juego.MostrarInformacion();

    string dificultad = "";
    string arma = "";

    while (!juegoIniciado)
    {
        Console.WriteLine("\n----------- Menú -----------");
        Console.WriteLine("1. Seleccionar dificultad");
        Console.WriteLine("2. Seleccionar arma");
        Console.WriteLine("3. Iniciar juego");
        Console.WriteLine("4. Salir");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\nSelecciona la dificultad (1.Fácil, 2.Medio, 3.Difícil):");
                dificultad = Console.ReadLine();
                juego.SeleccionarDificultad(dificultad);
                break;
            case 2:
                Console.WriteLine("\nSelecciona el arma (1.Espada, 2.Pistola, 3.Arco):");
                arma = Console.ReadLine();
                juego.SeleccionarArma(arma);
                break;
            case 3:
                if (!string.IsNullOrEmpty(dificultad) && !string.IsNullOrEmpty(arma))
                {
                    juego.IniciarPartida();
                    juegoIniciado = true;
                }
                else
                {
                    Console.WriteLine("\nPor favor selecciona la dificultad y el arma antes de iniciar el juego.");
                }
                break;
            case 4:
                Console.WriteLine("\n¡Gracias por jugar!");
                return;
            default:
                Console.WriteLine("\nOpción no válida.");
                break;
        }

        Console.WriteLine();
    }
}