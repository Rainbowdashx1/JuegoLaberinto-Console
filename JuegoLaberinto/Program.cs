using Business;
using System;

namespace JuegoLaberinto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool MenuOpc = true;
            Mensajes Msj = new Mensajes();
            LaberintoLayout Lab = new LaberintoLayout();

            while (MenuOpc) 
            {
                Console.Clear();
                Console.WriteLine(Msj.MsjBienVenida());
                Console.Write(Msj.MsjMenuOpcionesIni());
                try
                {
                    int Opcion = Convert.ToInt32(Console.ReadLine());
                    switch (Opcion) 
                    {
                        case 1:
                            Juego J = new Juego(Lab.RetornaLabernito());
                            J.IniciarPartida();
                            break;
                        case 2:
                            break;
                        case 3:
                            MenuOpc = false;
                            break;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(Msj.MsjErrorOpcionMenu());
                    Console.ReadLine();
                }
            }


        }
    }
}
