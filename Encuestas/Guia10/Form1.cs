using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia10
{
    public partial class Form1 : Form
    {
        #region Mis Variables
        int poblacion = 0, cantBici = 0, cantMoto = 0, cantAuto = 0, cantTp=0;

      

        double distPromedioBici = 0, disPromedioMoto = 0;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            lBresultados.Items.Clear();
            lBresultados.Items.Add($"Poblacion: {poblacion.ToString()}");
            lBresultados.Items.Add("---------------");
            lBresultados.Items.Add($"-Bicicleta: {cantBici.ToString()}");
            lBresultados.Items.Add($"-Motocicleta: {cantMoto.ToString()}");
            lBresultados.Items.Add($"-Automovil: {cantAuto.ToString()}");
            lBresultados.Items.Add($"-Transporte público: {cantTp.ToString()}");
            lBresultados.Items.Add("---------------");
            lBresultados.Items.Add("Distancia promedio por tipo de vehiculo:");
            lBresultados.Items.Add($"-Bicicleta: {distPromedioBici/cantBici}");
            lBresultados.Items.Add($"-Motocicleta: {disPromedioMoto/ cantMoto}");

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(rbBicicleta.Checked) {
                cantBici++;
                distPromedioBici += double.Parse(tbDistancia.Text);
            }
            if(rbMoto.Checked)
            {
                cantMoto++;
                disPromedioMoto += double.Parse(tbDistancia.Text);
            }
            if(rbAuto.Checked) { cantAuto++; }
            if(rbTransPublico.Checked) { cantTp++; }

            poblacion++;

            tbDistancia.Clear();

        }
    }
}
