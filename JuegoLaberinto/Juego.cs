using Business;
using System;
using System.Collections.Generic;
using System.Text;
using static Entidades.Entidad;

namespace JuegoLaberinto
{
    public class Juego
    {
        private string[,] Laberinto;
        private AccionesLaberinto ALB;
        private Mensajes Msj;
        public Juego(string[,] Laberinto) 
        {
            this.Laberinto = Laberinto;
            ALB = new AccionesLaberinto(Laberinto,1,37,"A");
            Msj = new Mensajes();
        }
        public void IniciarPartida() 
        {
            bool JuegoCorriendo = true;
            Console.Clear();
            while (JuegoCorriendo) 
            {
                Console.Clear();
                try
                {
                    Console.Write(Msj.MsjMenuOpcionesJuego());
                    int NumOpt = Convert.ToInt32(Console.ReadLine());

                    if (NumOpt == 1)
                    {

                        List<OpcionAccion> AccionesDespuesDeMirar = ALB.MirarAlRededor();
                        Console.WriteLine("**************PUEDES***************");
                        foreach (OpcionAccion Acc in AccionesDespuesDeMirar)
                        {
                            Console.WriteLine("Opcion " + Acc.idOpcion.ToString() + " : " + Acc.Opcion);
                        }
                        Console.Write("******************************\n--> ");

                        int OpcionUser = Convert.ToInt32(Console.ReadLine());
                        int ExisteOpcion = AccionesDespuesDeMirar.FindIndex(x => x.idOpcion == OpcionUser);
                        if (ExisteOpcion != -1)
                        {
                            string resultado = ALB.EjecutarAccion(AccionesDespuesDeMirar, OpcionUser);
                            if (resultado == "-2")
                            {
                                Console.WriteLine(Msj.MsjFinGame());
                                JuegoCorriendo = false;
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Porfavor solo use las opciones dispinbles");
                            Console.ReadLine();
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Porfavor solo use las opciones dispinbles");
                        Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Porfavor solo use las opciones dispinbles");
                    Console.ReadLine();
                }
            }
        }
    }
}
