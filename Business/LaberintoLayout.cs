using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class LaberintoLayout
    {
        private string[,] MatrizLaberinto;
        public LaberintoLayout() 
        {
            MatrizLaberinto = new string[13, 39];
            CrearTunelLaberinto();
        }

        public string[,] RetornaLabernito() 
        {
            return MatrizLaberinto;
        }
        
        private void CrearTunelLaberinto() 
        {
            MatrizLaberinto[11, 0] = "-2";
            MatrizLaberinto[11, 1] = "0";
            MatrizLaberinto[3, 2] = "0";
            MatrizLaberinto[4, 2] = "0";
            MatrizLaberinto[5, 2] = "0";
            MatrizLaberinto[6, 2] = "0";
            MatrizLaberinto[11, 2] = "0";
            MatrizLaberinto[3, 3] = "0";
            MatrizLaberinto[6, 3] = "0";
            MatrizLaberinto[11, 3] = "0";
            MatrizLaberinto[3, 4] = "0";
            MatrizLaberinto[6, 4] = "0";
            MatrizLaberinto[11, 4] = "0";
            MatrizLaberinto[3,5] = "0";
            MatrizLaberinto[5,5] = "0";
            MatrizLaberinto[6,5] = "0";
            MatrizLaberinto[7,5] = "0";
            MatrizLaberinto[8,5] = "0";
            MatrizLaberinto[9,5] = "0";
            MatrizLaberinto[10,5] = "0";
            MatrizLaberinto[11,5] = "0";
            MatrizLaberinto[3,6] = "0";
            MatrizLaberinto[5,6] = "0";
            MatrizLaberinto[8,6] = "0";
            MatrizLaberinto[3,7] = "0";
            MatrizLaberinto[5,7] = "0";
            MatrizLaberinto[8,7] = "0";
            MatrizLaberinto[3,8] = "0";
            MatrizLaberinto[4,8] = "0";
            MatrizLaberinto[5,8] = "0";
            MatrizLaberinto[8,8] = "0";
            MatrizLaberinto[5,9] = "0";
            MatrizLaberinto[8,9] = "0";
            MatrizLaberinto[5,10] = "0";
            MatrizLaberinto[8,10] = "0";
            MatrizLaberinto[5,11] = "0";
            MatrizLaberinto[8,11] = "0";
            MatrizLaberinto[5,12] = "0";
            MatrizLaberinto[8,12] = "0";
            MatrizLaberinto[5,13] = "0";
            MatrizLaberinto[6,13] = "0";
            MatrizLaberinto[7,13] = "0";
            MatrizLaberinto[8,13] = "0";
            MatrizLaberinto[5,14] = "0";
            MatrizLaberinto[8,14] = "0";
            MatrizLaberinto[5,15] = "0";
            MatrizLaberinto[8,15] = "0";
            MatrizLaberinto[5,16] = "0";
            MatrizLaberinto[8,16] = "0";
            MatrizLaberinto[2,17] = "0";
            MatrizLaberinto[3,17] = "0";
            MatrizLaberinto[4,17] = "0";
            MatrizLaberinto[5,17] = "0";
            MatrizLaberinto[6,17] = "0";
            MatrizLaberinto[7,17] = "0";
            MatrizLaberinto[8,17] = "0";
            MatrizLaberinto[11,17] = "0";
            MatrizLaberinto[2,18] = "0";
            MatrizLaberinto[5,18] = "0";
            MatrizLaberinto[8,18] = "0";
            MatrizLaberinto[11,18] = "0";
            MatrizLaberinto[2,19] = "0";
            MatrizLaberinto[5,19] = "0";
            MatrizLaberinto[8,19] = "0";
            MatrizLaberinto[11,19] = "0";
            MatrizLaberinto[2,20] = "0";
            MatrizLaberinto[5,20] = "0";
            MatrizLaberinto[8,20] = "0";
            MatrizLaberinto[11,20] = "0";
            MatrizLaberinto[2,21] = "0";
            MatrizLaberinto[5,21] = "0";
            MatrizLaberinto[8,21] = "0";
            MatrizLaberinto[11,21] = "0";
            MatrizLaberinto[2,22] = "0";
            MatrizLaberinto[5,22] = "0";
            MatrizLaberinto[8,22] = "0";
            MatrizLaberinto[9,22] = "0";
            MatrizLaberinto[10,22] = "0";
            MatrizLaberinto[11,22] = "0";
            MatrizLaberinto[2,23] = "0";
            MatrizLaberinto[5,23] = "0";
            MatrizLaberinto[8,23] = "0";
            MatrizLaberinto[2,24] = "0";
            MatrizLaberinto[5,24] = "0";
            MatrizLaberinto[8,24] = "0";
            MatrizLaberinto[2,25] = "0";
            MatrizLaberinto[5,25] = "0";
            MatrizLaberinto[8,25] = "0";
            MatrizLaberinto[1,26] = "0";
            MatrizLaberinto[2,26] = "0";
            MatrizLaberinto[3,26] = "0";
            MatrizLaberinto[4,26] = "0";
            MatrizLaberinto[5,26] = "0";
            MatrizLaberinto[6,26] = "0";
            MatrizLaberinto[7,26] = "0";
            MatrizLaberinto[8,26] = "0";
            MatrizLaberinto[9,26] = "0";
            MatrizLaberinto[10,26] = "0";
            MatrizLaberinto[11,26] = "0";
            MatrizLaberinto[1,27] = "0";
            MatrizLaberinto[3, 27] = "0";
            MatrizLaberinto[5, 27] = "0";
            MatrizLaberinto[10, 27] = "0";
            MatrizLaberinto[1,28] = "0";
            MatrizLaberinto[3,28] = "0";
            MatrizLaberinto[5,28] = "0";
            MatrizLaberinto[10,28] = "0";
            MatrizLaberinto[1,29] = "0";
            MatrizLaberinto[3,29] = "0";
            MatrizLaberinto[5,29] = "0";
            MatrizLaberinto[10,29] = "0";
            MatrizLaberinto[1,30] = "0";
            MatrizLaberinto[3,30] = "0";
            MatrizLaberinto[5,30] = "0";
            MatrizLaberinto[10,30] = "0";
            MatrizLaberinto[1,31] = "0";
            MatrizLaberinto[3,31] = "0";
            MatrizLaberinto[5,31] = "0";
            MatrizLaberinto[7,31] = "0";
            MatrizLaberinto[6,31] = "0";
            MatrizLaberinto[8,31] = "0";
            MatrizLaberinto[10,31] = "0";
            MatrizLaberinto[1,32] = "0";
            MatrizLaberinto[2,32] = "0";
            MatrizLaberinto[3,32] = "0";
            MatrizLaberinto[4,32] = "0";
            MatrizLaberinto[5,32] = "0";
            MatrizLaberinto[10,32] = "0";
            MatrizLaberinto[1,33] = "0";
            MatrizLaberinto[5,33] = "0";
            MatrizLaberinto[10,33] = "0";
            MatrizLaberinto[1,34] = "0";
            MatrizLaberinto[5,34] = "0";
            MatrizLaberinto[10,34] = "0";
            MatrizLaberinto[1,35] = "0";
            MatrizLaberinto[5,35] = "0";
            MatrizLaberinto[10,35] = "0";
            MatrizLaberinto[1,36] = "0";
            MatrizLaberinto[5,36] = "0";
            MatrizLaberinto[6,36] = "0";
            MatrizLaberinto[7,36] = "0";
            MatrizLaberinto[8,36] = "0";
            MatrizLaberinto[9,36] = "0";
            MatrizLaberinto[10,36] = "0";
            MatrizLaberinto[1,37] = "-1";
        }

    }
}
