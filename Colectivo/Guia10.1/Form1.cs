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
        #region misVariables
        double tiempoTotalReco = 0, tiempoDemora = 0, tiempoTotalDemoras = 0, porcenAsientosOcupados = 0;
        double horaInicio = 0,horaLLegada=0, minInicio = 0, horaParada = 0, horaSalida=0;

        int cantAsientos = 0, cantPasajeros = 0, cantParadas = 0, cantAsendidos = 0, cantDescendidos=0 ,cantDisponible=0;

        #endregion
        #region mis Metodos
        void reiciniaVariable()
        {
            tiempoTotalReco = 0; tiempoDemora = 0; tiempoTotalDemoras = 0; porcenAsientosOcupados = 0;
            cantAsientos = 0; cantPasajeros = 0; cantParadas = 0; horaInicio = 0; minInicio = 0; horaLLegada = 0;
        }
        #endregion
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            horaParada = double.Parse(tbHoraParada.Text) + (double.Parse(tbMinParada.Text) / 60);
            horaSalida = double.Parse(tbHoraSalida.Text) + (double.Parse(tbMinSalida.Text) / 60);
            tiempoDemora = horaSalida - horaParada; //calculamos el tiempo de demora
            cantDisponible = cantAsientos - cantPasajeros;// calculamos los ascientos disponibles

            tiempoTotalDemoras += tiempoDemora; //acumulamos el tiempo de demora de la parada
            



            //verificamos si hay espacio para los que quieren ascender
            if (int.Parse(tbAscienden.Text) <= cantDisponible)
            {
                cantPasajeros += int.Parse(tbAscienden.Text);
                cantAsendidos += int.Parse(tbAscienden.Text);   
            }
            else
            {
                MessageBox.Show("No hay lugar para esa cantidad de nuevos pasajeros");
                return;
            }

            //verificamos que no pongan un numero mayor a los pasajeros actuales
            if (int.Parse(tbDesciende.Text) <= cantDisponible)
            {
                if (cantPasajeros - int.Parse(tbDesciende.Text) < 0)
                {
                    MessageBox.Show("El numero que Descienden es mayor al numero de pasajeros actual");
                    return;
                }
                else
                {
                    cantPasajeros -= int.Parse(tbDesciende.Text);
                    cantDescendidos  += int.Parse(tbDesciende.Text);

                }
            }
            else
            {
                MessageBox.Show("No hay lugar para esa cantidad de nuevos pasajeros");
                return;
            }

            
            //cargamos listBox con los detalles al momento de la parada
            lbxParada.Items.Clear();
            lbxParada.Items.Add($"*Total de personas durante todo el viaje   ");
            lbxParada.Items.Add($" -Que han descendido: {cantDescendidos}");
            lbxParada.Items.Add($"-Que han ascendido: {cantAsendidos}");
            lbxParada.Items.Add($"*Demora de la parada: {tiempoDemora - (tiempoDemora % 60)} : {(tiempoDemora % 60)*60}:00");

            cantParadas++;// incrementamos la cantidad de parada
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbDesciende.Text = "0";
            tbAscienden.Text = "0";
            tbCantAsiento.Text = "0";
            tbPasajeros.Text = "0";
            gbxParada.Enabled = false;
        }

        private void btnIniciaReco_Click(object sender, EventArgs e)
        {
            reiciniaVariable();

            cantAsientos = int.Parse(tbCantAsiento.Text);
            cantPasajeros = int.Parse(tbPasajeros.Text);
            if(cantPasajeros < cantAsientos)
            {
                tbHoraParada.Text = tbHoraPartida.Text;
                tbMinParada.Text = tbMinPartida.Text;
                gbxInicia.Enabled = false;
                gbxParada.Enabled=true;
                horaInicio = int.Parse(tbHoraSalida.Text) + (int.Parse(tbMinSalida.Text)/60);

            }
            else
            {
                MessageBox.Show("Excede el limite de Pasajeros");
            }
            
        }

    }
}
