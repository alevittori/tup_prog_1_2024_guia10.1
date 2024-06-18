using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia10._1
{
    public partial class Form1 : Form
    {

        #region mis Variables
        int[] valoresTipoInfraccion = { 25, 30, 100, 85, 1500 };
        double[] reajusteTipoVehiculo = { 0.01, 0.5, 2 };
        double descuentoPagoEnLugar = 0.5;

        //Datos al infractor
        int dni;
        string nombre, patente;
        string[] tipoVehiculo = { "1 Eje", "2 Ejes", "3 Ejes o más" };
        double baseMonetaria; // (litros/costo litro)
        double costoLitro = 900;
        double subTotal = 0;
        double pagoEfectivo = 0;
        double pagoTotal = 0;
        int[] listaFaltasCheck = { 0, 0, 0, 0, 0 };
        int[] listaTipoCheck = { 0, 0, 0 };
        bool isPagoEfectivo = false;
        int cantTotalMultados = 0;
        double totalRecaudado = 0;
        double promedioRecaudado = 0;


        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Puesto de Control";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region registro todos los checkbox y radiobutoon

            //recojo todos los checkbox que selecciono
            if (chbxSinLuz.Checked) { listaFaltasCheck[0] = 1; }
            if (chbxMatafuego.Checked) { listaFaltasCheck[1] = 1; }
            if(chbxSobrevelocidad.Checked) { listaFaltasCheck[2] = 1; }
            if (chbxCinturon.Checked) { listaFaltasCheck[3]= 1; }
            if (chbxFaltaRespeto.Checked) { listaFaltasCheck[4]= 1; }


            // guardo el radioboton que este seleccionado
            if (rb1Eje.Checked)
            {
                listaTipoCheck[0] = 1;
            }
            else if(rb2Ejes.Checked)
            {
                listaTipoCheck[1] = 1;
            }
            else
            {
                listaTipoCheck[2] = 1;
            }

            //guardo si esta seleccionado el pagar en efectivo
            if(chbxPagoAhora.Checked) { isPagoEfectivo=true; }
            #endregion

            VRegistrar vRegistrar = new VRegistrar();
            if (vRegistrar.ShowDialog() == DialogResult.OK)
            {
                cantTotalMultados++; //acumulo la cantidad de multados

                //registro los datos del infractor
                nombre = vRegistrar.tbNombre.Text;
                dni=int.Parse( vRegistrar.tbDNI.Text);
                patente= vRegistrar.tbPatente.Text;


                //calculo los montos a pagar segun las faltas cometidas
                for (int i = 0; i < listaFaltasCheck.Length; i++)
                {
                    subTotal += (valoresTipoInfraccion[i] * listaFaltasCheck[i]) * costoLitro; //suma los valores de los chekbox que esten seleccionados
                }

                // calculo el reajuste segun el tipo de vehiculo
                for(int i = 0; i< listaTipoCheck.Length; i++)
                {
                    subTotal += subTotal * (listaTipoCheck[i] * reajusteTipoVehiculo[i]);
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar nuestro sistema");
            Close();
        }
    }
}
