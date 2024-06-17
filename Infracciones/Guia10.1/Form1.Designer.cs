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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbxSinLuz = new System.Windows.Forms.CheckBox();
            this.chbxMatafuego = new System.Windows.Forms.CheckBox();
            this.chbxSobrevelocidad = new System.Windows.Forms.CheckBox();
            this.chbxCinturon = new System.Windows.Forms.CheckBox();
            this.chbxFaltaRespeto = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb1Eje = new System.Windows.Forms.RadioButton();
            this.rb2Ejes = new System.Windows.Forms.RadioButton();
            this.rb3Ejes = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbxPagoAhora = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResumen);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Infraccion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbxFaltaRespeto);
            this.groupBox2.Controls.Add(this.chbxCinturon);
            this.groupBox2.Controls.Add(this.chbxSobrevelocidad);
            this.groupBox2.Controls.Add(this.chbxMatafuego);
            this.groupBox2.Controls.Add(this.chbxSinLuz);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 154);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de infraccion";
            // 
            // chbxSinLuz
            // 
            this.chbxSinLuz.AutoSize = true;
            this.chbxSinLuz.Location = new System.Drawing.Point(17, 32);
            this.chbxSinLuz.Name = "chbxSinLuz";
            this.chbxSinLuz.Size = new System.Drawing.Size(170, 20);
            this.chbxSinLuz.TabIndex = 0;
            this.chbxSinLuz.Text = "Sin luces bajas, ley 25...";
            this.chbxSinLuz.UseVisualStyleBackColor = true;
            // 
            // chbxMatafuego
            // 
            this.chbxMatafuego.AutoSize = true;
            this.chbxMatafuego.Location = new System.Drawing.Point(17, 54);
            this.chbxMatafuego.Name = "chbxMatafuego";
            this.chbxMatafuego.Size = new System.Drawing.Size(145, 20);
            this.chbxMatafuego.TabIndex = 1;
            this.chbxMatafuego.Text = "Falta de matafuego";
            this.chbxMatafuego.UseVisualStyleBackColor = true;
            // 
            // chbxSobrevelocidad
            // 
            this.chbxSobrevelocidad.AutoSize = true;
            this.chbxSobrevelocidad.Location = new System.Drawing.Point(17, 76);
            this.chbxSobrevelocidad.Name = "chbxSobrevelocidad";
            this.chbxSobrevelocidad.Size = new System.Drawing.Size(126, 20);
            this.chbxSobrevelocidad.TabIndex = 2;
            this.chbxSobrevelocidad.Text = "Sobrevelocidad";
            this.chbxSobrevelocidad.UseVisualStyleBackColor = true;
            // 
            // chbxCinturon
            // 
            this.chbxCinturon.AutoSize = true;
            this.chbxCinturon.Location = new System.Drawing.Point(17, 98);
            this.chbxCinturon.Name = "chbxCinturon";
            this.chbxCinturon.Size = new System.Drawing.Size(163, 20);
            this.chbxCinturon.TabIndex = 3;
            this.chbxCinturon.Text = "Falta CInturon o Casco";
            this.chbxCinturon.UseVisualStyleBackColor = true;
            // 
            // chbxFaltaRespeto
            // 
            this.chbxFaltaRespeto.AutoSize = true;
            this.chbxFaltaRespeto.Location = new System.Drawing.Point(17, 120);
            this.chbxFaltaRespeto.Name = "chbxFaltaRespeto";
            this.chbxFaltaRespeto.Size = new System.Drawing.Size(212, 20);
            this.chbxFaltaRespeto.TabIndex = 4;
            this.chbxFaltaRespeto.Text = "Falta de respeto a la autoridad";
            this.chbxFaltaRespeto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb3Ejes);
            this.groupBox3.Controls.Add(this.rb2Ejes);
            this.groupBox3.Controls.Add(this.rb1Eje);
            this.groupBox3.Location = new System.Drawing.Point(7, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 121);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Vehiculo";
            // 
            // rb1Eje
            // 
            this.rb1Eje.AutoSize = true;
            this.rb1Eje.Location = new System.Drawing.Point(17, 22);
            this.rb1Eje.Name = "rb1Eje";
            this.rb1Eje.Size = new System.Drawing.Size(58, 20);
            this.rb1Eje.TabIndex = 0;
            this.rb1Eje.TabStop = true;
            this.rb1Eje.Text = "1 Eje";
            this.rb1Eje.UseVisualStyleBackColor = true;
            // 
            // rb2Ejes
            // 
            this.rb2Ejes.AutoSize = true;
            this.rb2Ejes.Location = new System.Drawing.Point(17, 54);
            this.rb2Ejes.Name = "rb2Ejes";
            this.rb2Ejes.Size = new System.Drawing.Size(65, 20);
            this.rb2Ejes.TabIndex = 1;
            this.rb2Ejes.TabStop = true;
            this.rb2Ejes.Text = "2 Ejes";
            this.rb2Ejes.UseVisualStyleBackColor = true;
            // 
            // rb3Ejes
            // 
            this.rb3Ejes.AutoSize = true;
            this.rb3Ejes.Location = new System.Drawing.Point(17, 86);
            this.rb3Ejes.Name = "rb3Ejes";
            this.rb3Ejes.Size = new System.Drawing.Size(65, 20);
            this.rb3Ejes.TabIndex = 2;
            this.rb3Ejes.TabStop = true;
            this.rb3Ejes.Text = "3 Ejes";
            this.rb3Ejes.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbxPagoAhora);
            this.groupBox4.Location = new System.Drawing.Point(11, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 70);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pago en el lugar";
            // 
            // chbxPagoAhora
            // 
            this.chbxPagoAhora.AutoSize = true;
            this.chbxPagoAhora.Location = new System.Drawing.Point(22, 36);
            this.chbxPagoAhora.Name = "chbxPagoAhora";
            this.chbxPagoAhora.Size = new System.Drawing.Size(131, 20);
            this.chbxPagoAhora.TabIndex = 0;
            this.chbxPagoAhora.Text = "Realiza el pago?";
            this.chbxPagoAhora.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(338, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 292);
            this.listBox1.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(89, 395);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 48);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar Infraccion";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(414, 395);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(118, 48);
            this.btnResumen.TabIndex = 5;
            this.btnResumen.Text = "Ver resumen final";
            this.btnResumen.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(458, 523);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 571);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbxFaltaRespeto;
        private System.Windows.Forms.CheckBox chbxCinturon;
        private System.Windows.Forms.CheckBox chbxSobrevelocidad;
        private System.Windows.Forms.CheckBox chbxMatafuego;
        private System.Windows.Forms.CheckBox chbxSinLuz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb3Ejes;
        private System.Windows.Forms.RadioButton rb2Ejes;
        private System.Windows.Forms.RadioButton rb1Eje;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chbxPagoAhora;
        private System.Windows.Forms.Button btnSalir;
    }
}

