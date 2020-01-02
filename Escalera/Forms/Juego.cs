using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Escalera.Forms
{
    public partial class Juego : Form
    {
        private int ID;
        private bool observador;
        private int tablero_type;
        private Classes.Tablero t;
        private int sentido;
        private int dificultad;
        private int cont = 0;

        private int j1 = 0;
        private int j2 = 0;
        private int j3 = 0;
        private int j4 = 0;

        Classes.Conector connector = new Classes.Conector();
        String TramaIn;
        String TramaOut;
        public Juego(int id, bool obs, String NombrePort, int mode)
        {
            InitializeComponent();
            this.ID = id;
            this.observador = obs;
            this.tablero_type = 0;
            this.sentido = 0;
            this.dificultad = mode;

            if (this.ID == 1)
            {
                this.Mensaje.Text = "Selecciona un tablero";
                this.Mensaje.Visible = true;
                this.Dado.Enabled = true;
            }

            try
            {
                serialPort1.PortName = NombrePort;
                serialPort1.BaudRate = Convert.ToInt32("9600");
                serialPort1.DataBits = Convert.ToInt32("8");
                serialPort1.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            connector.USID = JugadorBit(this.ID);
        }


        private void Tablero_Click(object sender, EventArgs e)
        {

        }

        private void Dado_Click(object sender, EventArgs e)
        {
            this.Dado.Enabled = false;
            int d = LanzarDado();

            if (this.tablero_type == 0)
            {

                DecidirTablero(d);
                EnviarTablero(d);
            }
            else
            {
                if (this.cont == 3)
                {
                    if (d == 6)
                    {
                        this.cont = 0;
                        Moverse(d, this.ID);
                        EnviarMovimiento(d);
                    }
                    else
                        EnviarTurno();
                }
                else 
                {
                    Moverse(d, this.ID);
                    EnviarMovimiento(d);
                }

            }

        }

        private int LanzarDado()
        {
            Random i = new Random();
            int n = i.Next(1, 7);
            if (n == 7) n = 6;
            this.DadoL.Text = String.Concat(n);
            return n;
        }

        private void DecidirTablero(int i)
        {
            this.t = new Classes.Tablero(i);
            this.tablero_type = i;
            switch (i)
            {
                case 1:
                    this.Tablero.BackgroundImage = global::Escalera.Properties.Resources.tablero_1;
                    break;
                case 2:
                    this.Tablero.BackgroundImage = global::Escalera.Properties.Resources.tablero_2;
                    break;
                case 3:
                    this.Tablero.BackgroundImage = global::Escalera.Properties.Resources.tablero_3;
                    break;
                case 4:
                    this.Tablero.BackgroundImage = global::Escalera.Properties.Resources.tablero_4;
                    break;
                case 5:
                    this.Tablero.BackgroundImage = global::Escalera.Properties.Resources.tablero_5;
                    break;
                case 6:
                    this.Tablero.BackgroundImage = global::Escalera.Properties.Resources.tablero_6;
                    break;
            }
        }

        public void Moverse(int i, int id)
        {
            if (id == 1)
            {
                this.j1 += i;

                if (this.dificultad == 1 && this.j1 > 100)
                    this.j1 = 200 - this.j1;
                else if (this.dificultad == 0 && this.j1 > 100)
                    this.j1 = 100;

                this.Score1.Text = String.Concat(this.j1);

                if (t.CasillaEspecial(this.j1))
                {
                    SwitchSentido();
                    this.Mensaje.Text = "CAMBIO EL SENTIDO";
                    this.Mensaje.Visible = true;
                }

                while (t.CasillaTrampa(this.j1))
                {
                    this.Mensaje.Text = "CASILLA ESPECIAL!";
                    this.Mensaje.Visible = true;
                    Thread.Sleep(1000);
                    this.j1 = t.ObteberDestino(this.j1);
                    this.Score1.Text = String.Concat(this.j1);
                    if (t.CasillaEspecial(this.j1))
                    {
                        SwitchSentido();
                        this.Mensaje.Text = "CAMBIO EL SENTIDO";
                        this.Mensaje.Visible = true;
                    }
                }

                if (this.j1 == 100)
                    Ganador(id);
            }
            else if (id == 2)
            {
                this.j2 += i;
                if (this.dificultad == 1 && this.j2 > 100)
                    this.j2 = 200 - this.j2;
                else if (this.dificultad == 0 && this.j2 > 100)
                    this.j2 = 100;

                this.Score2.Text = String.Concat(this.j2);

                if (t.CasillaEspecial(this.j2))
                {
                    SwitchSentido();
                    this.Mensaje.Text = "CAMBIO EL SENTIDO";
                }

                while (t.CasillaTrampa(this.j2))
                {
                    this.Mensaje.Text = "CASILLA ESPECIAL!";
                    this.j2 = t.ObteberDestino(this.j2);
                    this.Score2.Text = String.Concat(this.j2);
                    if (t.CasillaEspecial(this.j2))
                    {
                        SwitchSentido();
                        this.Mensaje.Text = "CAMBIO EL SENTIDO";
                    }
                }

                if (this.j2 == 100)
                    Ganador(id);
            }
            else if (id == 3)
            {
                this.j3 += i;

                if (this.dificultad == 1 && this.j3 > 100)
                    this.j3 = 200 - this.j3;
                else if (this.dificultad == 0 && this.j3 > 100)
                    this.j3 = 100;

                this.Score3.Text = String.Concat(this.j3);

                if (t.CasillaEspecial(this.j3))
                {
                    SwitchSentido();
                    this.Mensaje.Text = "CAMBIO EL SENTIDO";
                }

                while (t.CasillaTrampa(this.j3))
                {
                    this.Mensaje.Text = "CASILLA ESPECIAL!";
                    this.j3 = t.ObteberDestino(this.j3);
                    this.Score3.Text = String.Concat(this.j3);
                    if (t.CasillaEspecial(this.j3))
                    {
                        SwitchSentido();
                        this.Mensaje.Text = "CAMBIO EL SENTIDO";
                    }
                }

                if (this.j3 == 100)
                    Ganador(id);
            }
            else
            {
                this.j4 += i;

                if (this.dificultad == 1 && this.j4 > 100)
                    this.j4 = 200 - this.j4;
                else if (this.dificultad == 0 && this.j4 > 100)
                    this.j4 = 100;

                this.Score4.Text = String.Concat(this.j4);

                if (t.CasillaEspecial(this.j4))
                {
                    SwitchSentido();
                    this.Mensaje.Text = "CAMBIO EL SENTIDO";
                }

                while (t.CasillaTrampa(this.j4))
                {
                    this.Mensaje.Text = "CASILLA ESPECIAL!";
                    this.j4 = t.ObteberDestino(this.j4);
                    this.Score4.Text = String.Concat(this.j4);
                    if (t.CasillaEspecial(this.j4))
                    {
                        SwitchSentido();
                        this.Mensaje.Text = "CAMBIO EL SENTIDO";
                    }
                }

                if (this.j4 == 100)
                    Ganador(id);
            }
            this.Mensaje.Visible = false;
        }

        public void SwitchSentido()
        {
            if (this.sentido == 0)
                this.sentido = 1;
            else
                this.sentido = 0;
        }

        public int NextPlayer()
        {
            switch(this.ID)
            {
                case 1:
                    if (this.sentido == 0)
                        return 2;
                    if (this.sentido == 1)
                        return 4;
                    break;
                case 2:
                    if (this.sentido == 0)
                        return 3;
                    if (this.sentido == 1)
                        return 1;
                    break;
                case 3:
                    if (this.sentido == 0)
                        return 4;
                    if (this.sentido == 1)
                        return 2;
                    break;
                case 4:
                    if (this.sentido == 0)
                        return 1;
                    if (this.sentido == 1)
                        return 3;
                    break;
            }
            return 0;
        }

        public void Ganador(int id)
        {
            MessageBox.Show(String.Concat("El ganador es el jugador ",id), "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Windows.Forms.Application.Exit();
        }

        public String JugadorBit(int i)
        {
            if (i == 1)
                return "00";
            else if (i == 2)
                return "01";
            else if (i == 3)
                return "10";
            else
                return "11";
        }

        public String DadoBit(int i)
        {
            if (i == 1)
                return "000";
            else if (i == 2)
                return "001";
            else if (i == 3)
                return "010";
            else if (i == 4)
                return "011";
            else if (i == 5)
                return "100";
            else if (i == 6)
                return "101";
            else
                return "111";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            TramaIn = serialPort1.ReadLine();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            connector.Control(TramaIn);
            if (TramaIn.Length >= 16)
            {
                switch (connector.Accion())
                {
                    case 1:                             // recibir tablero
                        if (this.ID == 1)
                        {
                            this.Mensaje.Text = "Tu Turno";
                            this.Dado.Enabled = true;
                        }
                        else
                        {
                            this.dificultad = connector.Dificultad();
                            Repetir();
                            DecidirTablero(connector.Dado());
                        }
                        break;

                    case 2:
                        if (connector.JugadorO() == this.ID)
                        {
                            Thread.Sleep(200);
                            if (connector.Dado() == 6)
                            {
                                this.cont += 1;
                                if (this.cont == 3)
                                    EnviarTurno();
                                else
                                    this.Dado.Enabled = true;
                            }
                            else
                            {
                                this.cont = 0;
                                EnviarTurno();
                            }
                        }
                        else
                        {
                            Repetir();
                            Moverse(connector.Dado(), connector.JugadorO());
                        }
                        break;

                    case 3:
                        break;

                    case 4:
                        if (connector.JugadorD() == this.ID)
                        {
                            if (this.observador == false)
                            {
                                this.Mensaje.Text = "Tu turno";
                                this.Mensaje.Visible = true;
                                this.Dado.Enabled = true;
                            }
                            else
                                EnviarTurno();
                        }
                        else
                        {
                            Repetir();
                        }
                        break;

                    case 5:
                        break;
                }
            }
        }

        private void Repetir()
        {
            TramaOut = TramaIn;
            serialPort1.WriteLine(TramaOut);
        }

        private void EnviarTablero(int i)
        {
            TramaOut = String.Concat("00", "00", "000", DadoBit(i), this.dificultad, "00000");
            serialPort1.WriteLine(TramaOut);
        }

        private void EnviarMovimiento(int d)
        {
            String player = JugadorBit(this.ID);
            TramaOut = String.Concat(player, player, "001", DadoBit(d), this.dificultad, "00000");
            serialPort1.WriteLine(TramaOut);
        }

        private void EnviarTurno()
        {
            TramaOut = String.Concat(JugadorBit(this.ID), JugadorBit(NextPlayer()), "011", "000", this.dificultad, "00000");
            serialPort1.WriteLine(TramaOut);
        }

    }
}
