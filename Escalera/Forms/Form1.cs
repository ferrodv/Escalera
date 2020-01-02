using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Escalera
{
    public partial class Form1 : Form
    {
        private int id;
        private String puerto;
        private bool observador;
        private int dificultad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Puertos_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            bJugar.Visible = true;
            bObservar.Visible = true;
            puerto = ListaPorts.Text;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ListaPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            ListaPorts.Items.AddRange(ports);
            ListaPorts.Enabled = true;
        }

        private void BJugar_Click(object sender, EventArgs e)
        {
            this.observador = false;
            bJugador1.Visible = true;
            bJugador1.Enabled = true;
            bJugador2.Visible = true;
            bJugador3.Visible = true;
            bJugador4.Visible = true;
        }

        private void BObservar_Click(object sender, EventArgs e)
        {
            this.observador = true;
            bJugador1.Visible = true;
            bJugador1.Enabled = false;
            bJugador2.Visible = true;
            bJugador3.Visible = true;
            bJugador4.Visible = true;
        }

        private void BJugador1_Click(object sender, EventArgs e)
        {
            this.id = 1;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            bObservar.Enabled = false;


            DificultadList.Items.Clear();
            string[] lista = { "Facil", "Dificil" };
            DificultadList.Items.AddRange(lista);
            DificultadList.Enabled = true;
            DificultadList.Visible = true;
        }

        private void BJugador2_Click(object sender, EventArgs e)
        {
            this.id = 2;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            Partida();
            this.WindowState = FormWindowState.Minimized;
            //System.Windows.Forms.Application.Exit();
        }

        private void BJugador3_Click(object sender, EventArgs e)
        {
            this.id = 3;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            Partida();
            System.Windows.Forms.Application.Exit();
        }

        private void BJugador4_Click(object sender, EventArgs e)
        {
            this.id = 4;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            Partida();
            System.Windows.Forms.Application.Exit();
        }

        private void Partida()
        {
            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void ThreadStart()
        {
            Application.Run(new Forms.Juego(this.id, this.observador, this.puerto, this.dificultad)); // <-- other form started on its own UI thread
        }

        private void DificultadList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DificultadList.Text == "Facil")
                dificultad = 0;
            else
                dificultad = 1;
            Partida();
            this.WindowState = FormWindowState.Minimized;
            //System.Windows.Forms.Application.Exit();
        }
    }
}
