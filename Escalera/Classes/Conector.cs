using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalera.Classes
{
    class Conector
    {
        private string userID;
        public string USID { get { return userID; } set { userID = value; } }

        private string dataO = string.Empty; //origen
        private string dataD = string.Empty; //destino
        private string dataA = string.Empty; //accion
        private string dataN = string.Empty; //numero dado
        private string dataS = string.Empty; //sentido

        public void Control(string data)
        {
            Flush(ref dataO, ref dataD, ref dataA, ref dataN, ref dataS);
            RepartirData(data, ref dataO, ref dataD, ref dataA, ref dataN, ref dataS);
        }

        public void Flush(ref String dataO, ref String dataD, ref String dataA, ref String dataN, ref String dataS)
        {
            this.dataO = string.Empty;
            this.dataD = string.Empty;
            this.dataA = string.Empty;
            this.dataN = string.Empty;
            this.dataS = string.Empty;
        }

        public void RepartirData(string data, ref String dataO, ref String dataD, ref String dataA, ref String dataN, ref String dataS)
        {
            int comp = 0;
            foreach (char c in data.ToCharArray())
            {
                ++comp;
                if (comp >= 1 && comp < 3)            //Llena los bits de jugador origen 
                {
                    this.dataO += c;
                }
                else if (comp >= 3 && comp < 5)       //Llena los bits de jugador destino
                {
                    this.dataD += c;
                }
                else if (comp >= 5 && comp < 8)       //Llena los bits de accion
                {
                    this.dataA += c;
                }
                else if (comp >= 8 && comp < 11)      //Llena los bits de Numero
                {
                    this.dataN += c;
                }
                else if (comp == 11)                  //Llena los bits de la dificultad
                {
                    this.dataS += c;
                }
            }

        }

        public int JugadorO()
        {
            switch (this.dataO)
            {
                case "00":
                    return 1;   // id jugador 1
                case "01":
                    return 2;   // id jugador 2
                case "10":
                    return 3;   // id jugador 3
                case "11":
                    return 4;   // id jugador 4
            }
            return 0; //error
        }

        public int JugadorD()
        {
            switch (this.dataD)
            {
                case "00":
                    return 1;   // id jugador 1
                case "01":
                    return 2;   // id jugador 2
                case "10":
                    return 3;   // id jugador 3
                case "11":
                    return 4;   // id jugador 4
            }
            return 0; //error
        }

        public int Accion()
        {
            switch (this.dataA)
            {
                case "000":
                    return 1;   // Seleccion tablero
                case "001":
                    return 2;   // Movimiento
                case "010":
                    return 3;   // Seleccion Jugador
                case "011":
                    return 4;   // Dar turno
                case "100":
                    return 5;   // Escoger Dificultad
            }
            return 0; //error
        }

        public int Dado()
        {
            switch (this.dataN)
            {
                case "000":
                    return 1;   
                case "001":
                    return 2;   
                case "010":
                    return 3;   
                case "011":
                    return 4;   
                case "100":
                    return 5;   
                case "101":
                    return 6;   
            }
            return 0; //error
        }

        public int Dificultad()
        {
            if (this.dataS == "0")
                return 0;
            else
                return 1;
        }

        public string getDataO()
        {
            return this.dataO;
        }

        public string getDataD()
        {
            return this.dataD;
        }

        public string getDataA()
        {
            return this.dataA;
        }

        public string getDataN()
        {
            return this.dataN;
        }

        public string getData()
        {
            return this.dataS;
        }
    }
}
