using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ManuelAldana
{
    public partial class Interes : Form
    {
        public Interes()
        {
            InitializeComponent();
        }       

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();     
            
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal Valor = 200000M;
            decimal tasa = 0.015M;
            decimal tiempo = 12M;
            decimal InteresTotal = 0M;


            for (int i = 1;i <= tiempo; i++) 
            {
                string mes = "";
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        mes = " Enero";
                        break;
                    case 2:
                        mes = " Febrero";
                        break;
                    case 3:
                        mes = " Marzo";
                        break;
                    case 4:
                        mes = " Abril";
                        break;
                    case 5:
                        mes = " Mayo";
                        break;
                    case 6:
                        mes = " Junio";
                        break;
                    case 7:
                        mes = " Julio";
                        break;
                    case 8:
                        mes = " Agosto";
                        break;
                    case 9:
                        mes = " Septiembre";
                        break;
                    case 10:
                        mes = "Octubre";
                        break;
                    case 11:
                        mes = "Noviembre";
                        break;
                    case 12:
                        mes = "Diciembre";
                        break;
                }

                decimal Total = Valor * tasa;                
                Valor =  Valor + Total;
                InteresTotal = InteresTotal + Total;
                string salida = Convert.ToString(i) + " - " + mes + "    : " + Convert.ToString(Total);
                listBox1.Items.Add(salida);

                
            }

            listBox1.Items.Add(" Total Intereses Ganados : " + Convert.ToString(InteresTotal));

        }
                
    }
}
