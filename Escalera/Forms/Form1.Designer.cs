namespace Escalera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaPorts = new System.Windows.Forms.ComboBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bObservar = new System.Windows.Forms.Button();
            this.bJugar = new System.Windows.Forms.Button();
            this.bJugador1 = new System.Windows.Forms.Button();
            this.bJugador2 = new System.Windows.Forms.Button();
            this.bJugador3 = new System.Windows.Forms.Button();
            this.bJugador4 = new System.Windows.Forms.Button();
            this.DificultadList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListaPorts
            // 
            this.ListaPorts.Enabled = false;
            this.ListaPorts.FormattingEnabled = true;
            this.ListaPorts.Location = new System.Drawing.Point(197, 172);
            this.ListaPorts.Name = "ListaPorts";
            this.ListaPorts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListaPorts.Size = new System.Drawing.Size(121, 21);
            this.ListaPorts.TabIndex = 0;
            this.ListaPorts.Text = "      Lista de puertos";
            this.ListaPorts.SelectedIndexChanged += new System.EventHandler(this.Puertos_list_SelectedIndexChanged);
            // 
            // bConnect
            // 
            this.bConnect.BackgroundImage = global::Escalera.Properties.Resources.black_twill;
            this.bConnect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bConnect.Location = new System.Drawing.Point(199, 114);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(119, 52);
            this.bConnect.TabIndex = 1;
            this.bConnect.Text = "Buscar puertos";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // bObservar
            // 
            this.bObservar.BackgroundImage = global::Escalera.Properties.Resources.black_twill;
            this.bObservar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bObservar.Image = global::Escalera.Properties.Resources.Button2;
            this.bObservar.Location = new System.Drawing.Point(199, 274);
            this.bObservar.Name = "bObservar";
            this.bObservar.Size = new System.Drawing.Size(119, 52);
            this.bObservar.TabIndex = 2;
            this.bObservar.Text = "Observar";
            this.bObservar.UseVisualStyleBackColor = true;
            this.bObservar.Visible = false;
            this.bObservar.Click += new System.EventHandler(this.BObservar_Click);
            // 
            // bJugar
            // 
            this.bJugar.BackgroundImage = global::Escalera.Properties.Resources.Button2;
            this.bJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bJugar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bJugar.Image = global::Escalera.Properties.Resources.Button2;
            this.bJugar.Location = new System.Drawing.Point(199, 228);
            this.bJugar.Name = "bJugar";
            this.bJugar.Size = new System.Drawing.Size(119, 52);
            this.bJugar.TabIndex = 3;
            this.bJugar.Text = "Jugar";
            this.bJugar.UseVisualStyleBackColor = true;
            this.bJugar.Visible = false;
            this.bJugar.Click += new System.EventHandler(this.BJugar_Click);
            // 
            // bJugador1
            // 
            this.bJugador1.BackColor = System.Drawing.Color.Transparent;
            this.bJugador1.BackgroundImage = global::Escalera.Properties.Resources.black_twill;
            this.bJugador1.ForeColor = System.Drawing.Color.Red;
            this.bJugador1.Image = global::Escalera.Properties.Resources.black_twill;
            this.bJugador1.Location = new System.Drawing.Point(428, 142);
            this.bJugador1.Name = "bJugador1";
            this.bJugador1.Size = new System.Drawing.Size(81, 36);
            this.bJugador1.TabIndex = 4;
            this.bJugador1.Text = "Jugador 1";
            this.bJugador1.UseVisualStyleBackColor = false;
            this.bJugador1.Visible = false;
            this.bJugador1.Click += new System.EventHandler(this.BJugador1_Click);
            // 
            // bJugador2
            // 
            this.bJugador2.BackColor = System.Drawing.Color.Transparent;
            this.bJugador2.BackgroundImage = global::Escalera.Properties.Resources.black_twill;
            this.bJugador2.ForeColor = System.Drawing.Color.Blue;
            this.bJugador2.Image = global::Escalera.Properties.Resources.black_twill;
            this.bJugador2.Location = new System.Drawing.Point(562, 142);
            this.bJugador2.Name = "bJugador2";
            this.bJugador2.Size = new System.Drawing.Size(81, 36);
            this.bJugador2.TabIndex = 5;
            this.bJugador2.Text = "Jugador 2";
            this.bJugador2.UseVisualStyleBackColor = false;
            this.bJugador2.Visible = false;
            this.bJugador2.Click += new System.EventHandler(this.BJugador2_Click);
            // 
            // bJugador3
            // 
            this.bJugador3.BackColor = System.Drawing.Color.Transparent;
            this.bJugador3.BackgroundImage = global::Escalera.Properties.Resources.black_twill;
            this.bJugador3.ForeColor = System.Drawing.Color.Purple;
            this.bJugador3.Image = global::Escalera.Properties.Resources.black_twill;
            this.bJugador3.Location = new System.Drawing.Point(428, 244);
            this.bJugador3.Name = "bJugador3";
            this.bJugador3.Size = new System.Drawing.Size(81, 36);
            this.bJugador3.TabIndex = 6;
            this.bJugador3.Text = "Jugador 3";
            this.bJugador3.UseVisualStyleBackColor = false;
            this.bJugador3.Visible = false;
            this.bJugador3.Click += new System.EventHandler(this.BJugador3_Click);
            // 
            // bJugador4
            // 
            this.bJugador4.BackColor = System.Drawing.Color.Transparent;
            this.bJugador4.BackgroundImage = global::Escalera.Properties.Resources.black_twill;
            this.bJugador4.ForeColor = System.Drawing.Color.Lime;
            this.bJugador4.Image = global::Escalera.Properties.Resources.black_twill;
            this.bJugador4.Location = new System.Drawing.Point(562, 244);
            this.bJugador4.Name = "bJugador4";
            this.bJugador4.Size = new System.Drawing.Size(81, 36);
            this.bJugador4.TabIndex = 7;
            this.bJugador4.Text = "Jugador 4";
            this.bJugador4.UseVisualStyleBackColor = false;
            this.bJugador4.Visible = false;
            this.bJugador4.Click += new System.EventHandler(this.BJugador4_Click);
            // 
            // DificultadList
            // 
            this.DificultadList.Enabled = false;
            this.DificultadList.FormattingEnabled = true;
            this.DificultadList.Location = new System.Drawing.Point(473, 199);
            this.DificultadList.Name = "DificultadList";
            this.DificultadList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DificultadList.Size = new System.Drawing.Size(121, 21);
            this.DificultadList.TabIndex = 8;
            this.DificultadList.Text = "Dificultad";
            this.DificultadList.Visible = false;
            this.DificultadList.SelectedIndexChanged += new System.EventHandler(this.DificultadList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escalera.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DificultadList);
            this.Controls.Add(this.bJugador4);
            this.Controls.Add(this.bJugador3);
            this.Controls.Add(this.bJugador2);
            this.Controls.Add(this.bJugador1);
            this.Controls.Add(this.bJugar);
            this.Controls.Add(this.bObservar);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.ListaPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ListaPorts;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bObservar;
        private System.Windows.Forms.Button bJugar;
        private System.Windows.Forms.Button bJugador1;
        private System.Windows.Forms.Button bJugador2;
        private System.Windows.Forms.Button bJugador3;
        private System.Windows.Forms.Button bJugador4;
        private System.Windows.Forms.ComboBox DificultadList;
    }
}

