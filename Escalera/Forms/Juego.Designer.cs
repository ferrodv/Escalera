namespace Escalera.Forms
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Tableros = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score3 = new System.Windows.Forms.Label();
            this.Score4 = new System.Windows.Forms.Label();
            this.Mensaje = new System.Windows.Forms.Label();
            this.Dado = new System.Windows.Forms.Button();
            this.Tablero = new System.Windows.Forms.Button();
            this.DadoL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Tableros
            // 
            this.Tableros.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Tableros.ImageStream")));
            this.Tableros.TransparentColor = System.Drawing.Color.Transparent;
            this.Tableros.Images.SetKeyName(0, "tablero-1.jpg");
            this.Tableros.Images.SetKeyName(1, "tablero-2.jpg");
            this.Tableros.Images.SetKeyName(2, "tablero-3.jpg");
            this.Tableros.Images.SetKeyName(3, "tablero-4.jpg");
            this.Tableros.Images.SetKeyName(4, "tablero-5.jpg");
            this.Tableros.Images.SetKeyName(5, "tablero-6.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jugador 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jugador 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jugador 4:";
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.ForeColor = System.Drawing.Color.Red;
            this.Score1.Location = new System.Drawing.Point(75, 41);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(13, 13);
            this.Score1.TabIndex = 5;
            this.Score1.Text = "0";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.ForeColor = System.Drawing.Color.Blue;
            this.Score2.Location = new System.Drawing.Point(75, 72);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(13, 13);
            this.Score2.TabIndex = 6;
            this.Score2.Text = "0";
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Score3.Location = new System.Drawing.Point(75, 104);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(13, 13);
            this.Score3.TabIndex = 7;
            this.Score3.Text = "0";
            // 
            // Score4
            // 
            this.Score4.AutoSize = true;
            this.Score4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Score4.Location = new System.Drawing.Point(75, 135);
            this.Score4.Name = "Score4";
            this.Score4.Size = new System.Drawing.Size(13, 13);
            this.Score4.TabIndex = 8;
            this.Score4.Text = "0";
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mensaje.Location = new System.Drawing.Point(12, 219);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(47, 13);
            this.Mensaje.TabIndex = 9;
            this.Mensaje.Text = "Tu turno";
            this.Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mensaje.Visible = false;
            // 
            // Dado
            // 
            this.Dado.Enabled = false;
            this.Dado.Location = new System.Drawing.Point(34, 253);
            this.Dado.Name = "Dado";
            this.Dado.Size = new System.Drawing.Size(75, 23);
            this.Dado.TabIndex = 10;
            this.Dado.Text = "Lanzar dado";
            this.Dado.UseVisualStyleBackColor = true;
            this.Dado.Click += new System.EventHandler(this.Dado_Click);
            // 
            // Tablero
            // 
            this.Tablero.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Tablero.BackgroundImage = global::Escalera.Properties.Resources.Fondo;
            this.Tablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tablero.ImageKey = "(ninguno)";
            this.Tablero.ImageList = this.Tableros;
            this.Tablero.Location = new System.Drawing.Point(144, 12);
            this.Tablero.Name = "Tablero";
            this.Tablero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tablero.Size = new System.Drawing.Size(644, 426);
            this.Tablero.TabIndex = 0;
            this.Tablero.UseVisualStyleBackColor = false;
            this.Tablero.Click += new System.EventHandler(this.Tablero_Click);
            // 
            // DadoL
            // 
            this.DadoL.AutoSize = true;
            this.DadoL.ForeColor = System.Drawing.Color.White;
            this.DadoL.Location = new System.Drawing.Point(64, 295);
            this.DadoL.Name = "DadoL";
            this.DadoL.Size = new System.Drawing.Size(13, 13);
            this.DadoL.TabIndex = 11;
            this.DadoL.Text = "0";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DadoL);
            this.Controls.Add(this.Dado);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.Score4);
            this.Controls.Add(this.Score3);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tablero);
            this.Name = "Juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Tablero;
        private System.Windows.Forms.ImageList Tableros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score3;
        private System.Windows.Forms.Label Score4;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.Button Dado;
        private System.Windows.Forms.Label DadoL;
    }
}