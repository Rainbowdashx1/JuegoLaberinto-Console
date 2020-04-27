using System;
using System.Collections.Generic;
using System.Text;
using static Entidades.Entidad;

namespace Business
{
    public class AccionesLaberinto
    {
        private int PosicionActualX;
        private int PosicionActualY;

        private int PosicionMaximaX = 12;
        private int PosicionMaximaY = 37;

        private string[,] Laberinto;
        private string Mira; // CON LETRAS A ARRIBA B IZQUIERDA C ABAJO Y D DERECHA 
        public AccionesLaberinto(string[,] Laberinto, int PosicionX, int PosicionY, string Mira)
        {
            PosicionActualX = PosicionX;
            PosicionActualY = PosicionY;
            this.Mira = Mira;
            this.Laberinto = Laberinto;
        }
        public List<OpcionAccion> MirarAlRededor()
        {
            string Mira1 = Laberinto[PosicionActualX, PosicionActualY - 1];
            string Mira2 = Laberinto[PosicionActualX - 1, PosicionActualY];
            string Mira3 = Laberinto[PosicionActualX + 1, PosicionActualY];
            string Mira4 = Laberinto[PosicionActualX, PosicionActualY + 1];

            return PosiblesAccion_SegunLoQueSeVe(Mira1, Mira2, Mira3, Mira4);
        }
        public string EjecutarAccion(List<OpcionAccion> accionesDespuesDeMirar, int opcionUser)
        {
            OpcionAccion Opcion = accionesDespuesDeMirar.Find(x => x.idOpcion == opcionUser);
            switch (Mira)
            {
                case "A":
                    if (Opcion.idOperacion == 0) 
                    {
                        PosicionActualY = PosicionActualY - 1;
                    }
                    if (Opcion.idOperacion == 1)
                    {
                        Mira = "D";
                    }
                    if (Opcion.idOperacion == 2)
                    {
                        Mira = "B";
                    }
                    if (Opcion.idOperacion == 3)
                    {
                        Mira = "C";
                    }
                    break;
                case "B":
                    if (Opcion.idOperacion == 0)
                    {
                        Mira = "A";
                    }
                    if (Opcion.idOperacion == 1)
                    {
                        Mira = "D";
                    }
                    if (Opcion.idOperacion == 2)
                    {
                        PosicionActualX = PosicionActualX + 1;
                    }
                    if (Opcion.idOperacion == 3)
                    {
                        Mira = "C";
                    }
                    break;
                case "C":
                    if (Opcion.idOperacion == 0)
                    {
                        Mira = "A";
                    }
                    if (Opcion.idOperacion == 1)
                    {
                        Mira = "D";
                    }
                    if (Opcion.idOperacion == 2)
                    {
                        Mira = "B";
                    }
                    if (Opcion.idOperacion == 3)
                    {
                        PosicionActualY = PosicionActualY + 1;
                    }
                    break;
                case "D":
                    if (Opcion.idOperacion == 0)
                    {
                        Mira = "A";
                    }
                    if (Opcion.idOperacion == 1)
                    {
                        PosicionActualX = PosicionActualX - 1;
                    }
                    if (Opcion.idOperacion == 2)
                    {
                        Mira = "B";
                    }
                    if (Opcion.idOperacion == 3)
                    {
                        Mira = "C";
                    }
                    break;
            }
            return Laberinto[PosicionActualX, PosicionActualY];
        }
        public List<OpcionAccion> PosiblesAccion_SegunLoQueSeVe(string Mira1, string Mira2, string Mira3, string Mira4) 
        {
            List<OpcionAccion> AccionesEncontradas = new List<OpcionAccion>();
            int opcion = 0;
            switch (Mira) 
            {
                case "A":
                    if (Mira1 == "0" || Mira1 =="-1" || Mira1 =="-2") 
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 0,Opcion = "Avazar hacia adelante (1 paso)" });
                        opcion++;
                    }
                    if (Mira2 == "0" || Mira2 == "-1" || Mira2 == "-2") 
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 1, Opcion = "Hay un pasillo a la izquierda y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira3 == "0" || Mira3 == "-1" || Mira3 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 2, Opcion = "Hay un pasillo a la derecha y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira4 == "0" || Mira4 == "-1" || Mira4 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 3, Opcion = "Media vuelta (Solo giro no avanzo)" });
                        opcion++;
                    }
                    break;
                case "B":
                    if (Mira1 == "0" || Mira1 == "-1" || Mira1 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 0, Opcion = "Hay un pasillo a la izquierda y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira2 == "0" || Mira2 == "-1" || Mira2 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 1, Opcion = "Media vuelta (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira3 == "0" || Mira3 == "-1" || Mira3 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 2, Opcion = "Avazar hacia adelante (1 paso)" });
                        opcion++;
                    }
                    if (Mira4 == "0" || Mira4 == "-1" || Mira4 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 3, Opcion = "Hay un pasillo a la derecha y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    break;
                case "C":
                    if (Mira1 == "0" || Mira1 == "-1" || Mira1 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 0, Opcion = "Media vuelta (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira2 == "0" || Mira2 == "-1" || Mira2 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 1, Opcion = "Hay un pasillo a la derecha y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira3 == "0" || Mira3 == "-1" || Mira3 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 2, Opcion = "Hay un pasillo a la izquierda y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira4 == "0" || Mira4 == "-1" || Mira4 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 3, Opcion = "Avazar hacia adelante (1 paso)" });
                        opcion++;
                    }
                    break;
                case "D":
                    if (Mira1 == "0" || Mira1 == "-1" || Mira1 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 0, Opcion = "Hay un pasillo a la derecha y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira2 == "0" || Mira2 == "-1" || Mira2 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 1, Opcion = "Avazar hacia adelante (1 paso)" });
                        opcion++;
                    }
                    if (Mira3 == "0" || Mira3 == "-1" || Mira3 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 2, Opcion = "Media vuelta (Solo giro no avanzo)" });
                        opcion++;
                    }
                    if (Mira4 == "0" || Mira4 == "-1" || Mira4 == "-2")
                    {
                        AccionesEncontradas.Add(new OpcionAccion { idOpcion = opcion, idOperacion = 3, Opcion = "Hay un pasillo a la izquierda y puedes girar (Solo giro no avanzo)" });
                        opcion++;
                    }
                    break;
            }
            return AccionesEncontradas;
        }
    }
}
