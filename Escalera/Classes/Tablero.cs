using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalera.Classes
{
    class Tablero
    {
        private int[] especiales;
        private int[] origen;
        private int[] destino;
        private bool  corrido;
        private String fondo;

        public Tablero()
        {
            this.especiales = new int[3] {0, 0, 0};
            this.origen = new int[1] { 0 };
            this.destino = new int[1] { 0 };
            this.corrido = true;
            this.fondo = "Fondo";
    }
        public Tablero(int i)
        {
            switch (i)
            {
                case 1:
                    this.especiales = new int[3] { 18 , 46 , 85 };
                    this.origen = new int[12] { 5, 9, 23, 36, 49, 48, 56, 62, 69, 82, 87, 96 };
                    this.destino = new int[12] { 35, 51, 42, 5, 7, 86, 8, 83, 91, 20, 66, 38 };
                    this.corrido = true;
                    break;
                case 2:
                    this.especiales = new int[3] { 17 , 45 , 86 };
                    this.origen = new int[21] { 2, 7, 8, 15, 16, 21, 28, 36, 46, 49, 51, 62, 64, 71, 74, 78, 87, 89, 92, 95, 99};
                    this.destino = new int[21] { 38, 14, 31, 26, 6, 42, 84, 44, 25, 11, 67, 19, 60, 91, 53, 98, 94, 68, 88, 75, 80};
                    this.corrido = true;
                    break;
                case 3:
                    this.especiales = new int[3] { 23 , 54 , 88 };
                    this.origen = new int[9] { 5, 14, 38, 51, 53, 64, 76, 91, 97};
                    this.destino = new int[9] { 58, 49, 20, 10, 72, 83, 54, 73, 61};
                    this.corrido = true;
                    break;
                case 4:
                    this.especiales = new int[3] { 13 , 41 , 94 };
                    this.origen = new int[10] {9, 16, 18, 32, 48, 50, 63,74, 99, 86};
                    this.destino = new int[10] {31, 45, 64, 6, 66, 93, 81, 22, 39, 51 };
                    this.corrido = true;
                    break;
                case 5:
                    this.especiales = new int[3] { 12 , 48 , 94 };
                    this.origen = new int[16] {1, 4, 9, 17, 21, 28, 51, 54, 62, 64, 72, 80, 87, 93, 95, 98};
                    this.destino = new int[16] { 38, 14, 31, 7, 42, 84, 67, 34, 19, 60, 91, 99, 36, 73, 75, 79 };
                    this.corrido = true;
                    break;
                case 6:
                    this.especiales = new int[3] { 17 , 41 , 81 };
                    this.origen = new int[13] {2, 6, 20, 30, 37, 52, 56, 57, 74, 78, 84, 87, 99};
                    this.destino = new int[13] {23, 45, 59, 16, 3, 72, 8, 96, 94, 98, 64, 31, 40 };
                    this.corrido = true;

                    break;
            }
            this.fondo = String.Concat("tablero-", i, "jpg");
        }

        public String GetFondo()
        {
            return this.fondo;
        }

        public bool CasillaTrampa(int i)
        {
            return this.origen.Contains(i);
        }

        public bool CasillaEspecial(int i)
        {
            return this.especiales.Contains(i);
        }

        public int ObteberDestino(int i)
        {
            return this.destino[Array.IndexOf(this.origen, i)];
        }
    }
}
