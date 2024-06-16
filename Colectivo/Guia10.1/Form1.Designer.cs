namespace Guia10._1
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
            this.gbxInicia = new System.Windows.Forms.GroupBox();
            this.gbxParada = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoraPartida = new System.Windows.Forms.TextBox();
            this.tbMinPartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantAsiento = new System.Windows.Forms.TextBox();
            this.btnIniciaReco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHoraParada = new System.Windows.Forms.TextBox();
            this.tbMinParada = new System.Windows.Forms.TextBox();
            this.tbDesciende = new System.Windows.Forms.TextBox();
            this.tbHoraSalida = new System.Windows.Forms.TextBox();
            this.tbMinSalida = new System.Windows.Forms.TextBox();
            this.tbAscienden = new System.Windows.Forms.TextBox();
            this.tbHoraFin = new System.Windows.Forms.TextBox();
            this.tbMinFin = new System.Windows.Forms.TextBox();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnFinReco = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxParada = new System.Windows.Forms.ListBox();
            this.lbxInforme = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbPasajeros = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbxInicia.SuspendLayout();
            this.gbxParada.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInicia
            // 
            this.gbxInicia.Controls.Add(this.tbPasajeros);
            this.gbxInicia.Controls.Add(this.label12);
            this.gbxInicia.Controls.Add(this.btnIniciaReco);
            this.gbxInicia.Controls.Add(this.tbCantAsiento);
            this.gbxInicia.Controls.Add(this.label3);
            this.gbxInicia.Controls.Add(this.tbMinPartida);
            this.gbxInicia.Controls.Add(this.tbHoraPartida);
            this.gbxInicia.Controls.Add(this.label2);
            this.gbxInicia.Controls.Add(this.label1);
            this.gbxInicia.Location = new System.Drawing.Point(12, 12);
            this.gbxInicia.Name = "gbxInicia";
            this.gbxInicia.Size = new System.Drawing.Size(320, 426);
            this.gbxInicia.TabIndex = 0;
            this.gbxInicia.TabStop = false;
            this.gbxInicia.Text = "Iniciar Recorrido";
            // 
            // gbxParada
            // 
            this.gbxParada.Controls.Add(this.label11);
            this.gbxParada.Controls.Add(this.label10);
            this.gbxParada.Controls.Add(this.lbxParada);
            this.gbxParada.Controls.Add(this.btnRegistra);
            this.gbxParada.Controls.Add(this.tbAscienden);
            this.gbxParada.Controls.Add(this.tbMinSalida);
            this.gbxParada.Controls.Add(this.tbHoraSalida);
            this.gbxParada.Controls.Add(this.tbDesciende);
            this.gbxParada.Controls.Add(this.tbMinParada);
            this.gbxParada.Controls.Add(this.tbHoraParada);
            this.gbxParada.Controls.Add(this.label7);
            this.gbxParada.Controls.Add(this.label6);
            this.gbxParada.Controls.Add(this.label5);
            this.gbxParada.Controls.Add(this.label4);
            this.gbxParada.Location = new System.Drawing.Point(338, 12);
            this.gbxParada.Name = "gbxParada";
            this.gbxParada.Size = new System.Drawing.Size(344, 426);
            this.gbxParada.TabIndex = 1;
            this.gbxParada.TabStop = false;
            this.gbxParada.Text = "Parada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbxInforme);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnFinReco);
            this.groupBox3.Controls.Add(this.tbMinFin);
            this.groupBox3.Controls.Add(this.tbHoraFin);
            this.groupBox3.Location = new System.Drawing.Point(688, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 426);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finalizar Recorrido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Partida (HH:MM)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Asientos";
            // 
            // tbHoraPartida
            // 
            this.tbHoraPartida.Location = new System.Drawing.Point(174, 73);
            this.tbHoraPartida.Name = "tbHoraPartida";
            this.tbHoraPartida.Size = new System.Drawing.Size(38, 22);
            this.tbHoraPartida.TabIndex = 2;
            // 
            // tbMinPartida
            // 
            this.tbMinPartida.Location = new System.Drawing.Point(223, 73);
            this.tbMinPartida.Name = "tbMinPartida";
            this.tbMinPartida.Size = new System.Drawing.Size(38, 22);
            this.tbMinPartida.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // tbCantAsiento
            // 
            this.tbCantAsiento.Location = new System.Drawing.Point(223, 111);
            this.tbCantAsiento.Name = "tbCantAsiento";
            this.tbCantAsiento.Size = new System.Drawing.Size(76, 22);
            this.tbCantAsiento.TabIndex = 5;
            // 
            // btnIniciaReco
            // 
            this.btnIniciaReco.Location = new System.Drawing.Point(90, 218);
            this.btnIniciaReco.Name = "btnIniciaReco";
            this.btnIniciaReco.Size = new System.Drawing.Size(103, 57);
            this.btnIniciaReco.TabIndex = 6;
            this.btnIniciaReco.Text = "Iniciar Recorrido";
            this.btnIniciaReco.UseVisualStyleBackColor = true;
            this.btnIniciaReco.Click += new System.EventHandler(this.btnIniciaReco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Llegada (HH:MM)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descienden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Salida (HH:MM)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ascienden";
            // 
            // tbHoraParada
            // 
            this.tbHoraParada.Location = new System.Drawing.Point(151, 45);
            this.tbHoraParada.Name = "tbHoraParada";
            this.tbHoraParada.Size = new System.Drawing.Size(38, 22);
            this.tbHoraParada.TabIndex = 7;
            // 
            // tbMinParada
            // 
            this.tbMinParada.Location = new System.Drawing.Point(211, 45);
            this.tbMinParada.Name = "tbMinParada";
            this.tbMinParada.Size = new System.Drawing.Size(38, 22);
            this.tbMinParada.TabIndex = 8;
            // 
            // tbDesciende
            // 
            this.tbDesciende.Location = new System.Drawing.Point(151, 86);
            this.tbDesciende.Name = "tbDesciende";
            this.tbDesciende.Size = new System.Drawing.Size(38, 22);
            this.tbDesciende.TabIndex = 9;
            // 
            // tbHoraSalida
            // 
            this.tbHoraSalida.Location = new System.Drawing.Point(151, 130);
            this.tbHoraSalida.Name = "tbHoraSalida";
            this.tbHoraSalida.Size = new System.Drawing.Size(38, 22);
            this.tbHoraSalida.TabIndex = 10;
            // 
            // tbMinSalida
            // 
            this.tbMinSalida.Location = new System.Drawing.Point(211, 130);
            this.tbMinSalida.Name = "tbMinSalida";
            this.tbMinSalida.Size = new System.Drawing.Size(38, 22);
            this.tbMinSalida.TabIndex = 11;
            // 
            // tbAscienden
            // 
            this.tbAscienden.Location = new System.Drawing.Point(151, 167);
            this.tbAscienden.Name = "tbAscienden";
            this.tbAscienden.Size = new System.Drawing.Size(38, 22);
            this.tbAscienden.TabIndex = 12;
            // 
            // tbHoraFin
            // 
            this.tbHoraFin.Location = new System.Drawing.Point(238, 46);
            this.tbHoraFin.Name = "tbHoraFin";
            this.tbHoraFin.Size = new System.Drawing.Size(38, 22);
            this.tbHoraFin.TabIndex = 13;
            // 
            // tbMinFin
            // 
            this.tbMinFin.Location = new System.Drawing.Point(294, 46);
            this.tbMinFin.Name = "tbMinFin";
            this.tbMinFin.Size = new System.Drawing.Size(38, 22);
            this.tbMinFin.TabIndex = 14;
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(136, 218);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(103, 57);
            this.btnRegistra.TabIndex = 7;
            this.btnRegistra.Text = "Registrar Parada";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnFinReco
            // 
            this.btnFinReco.Location = new System.Drawing.Point(238, 113);
            this.btnFinReco.Name = "btnFinReco";
            this.btnFinReco.Size = new System.Drawing.Size(103, 57);
            this.btnFinReco.TabIndex = 13;
            this.btnFinReco.Text = "Finalizar Recorrido";
            this.btnFinReco.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fora de Finalizacion (HH:MM)";
            // 
            // lbxParada
            // 
            this.lbxParada.FormattingEnabled = true;
            this.lbxParada.ItemHeight = 16;
            this.lbxParada.Location = new System.Drawing.Point(6, 300);
            this.lbxParada.Name = "lbxParada";
            this.lbxParada.Size = new System.Drawing.Size(332, 116);
            this.lbxParada.TabIndex = 13;
            // 
            // lbxInforme
            // 
            this.lbxInforme.FormattingEnabled = true;
            this.lbxInforme.ItemHeight = 16;
            this.lbxInforme.Location = new System.Drawing.Point(6, 205);
            this.lbxInforme.Name = "lbxInforme";
            this.lbxInforme.Size = new System.Drawing.Size(387, 212);
            this.lbxInforme.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = ":";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(926, 454);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // tbPasajeros
            // 
            this.tbPasajeros.Location = new System.Drawing.Point(223, 151);
            this.tbPasajeros.Name = "tbPasajeros";
            this.tbPasajeros.Size = new System.Drawing.Size(76, 22);
            this.tbPasajeros.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Cantidad de Pasajeros Inicial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 515);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxParada);
            this.Controls.Add(this.gbxInicia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxInicia.ResumeLayout(false);
            this.gbxInicia.PerformLayout();
            this.gbxParada.ResumeLayout(false);
            this.gbxParada.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInicia;
        private System.Windows.Forms.GroupBox gbxParada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIniciaReco;
        private System.Windows.Forms.TextBox tbCantAsiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMinPartida;
        private System.Windows.Forms.TextBox tbHoraPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMinSalida;
        private System.Windows.Forms.TextBox tbHoraSalida;
        private System.Windows.Forms.TextBox tbDesciende;
        private System.Windows.Forms.TextBox tbMinParada;
        private System.Windows.Forms.TextBox tbHoraParada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbxParada;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.TextBox tbAscienden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbxInforme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinReco;
        private System.Windows.Forms.TextBox tbMinFin;
        private System.Windows.Forms.TextBox tbHoraFin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbPasajeros;
        private System.Windows.Forms.Label label12;
    }
}

