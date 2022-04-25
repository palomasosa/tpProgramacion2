using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareaProgramacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = System.Convert.ToInt32(nmDía.Value);
            string mes = System.Convert.ToString(nmMes.Value);
            int año = System.Convert.ToInt32(nmAño.Value);

            int diasMes = 0;
            int esValido = 1;


            if (mes == "1"|| mes == "3"|| mes == "5"|| mes == "7"|| mes == "8"|| mes == "10"|| mes == "12")
            {
                diasMes = 1;
            }
            else if (mes == "2")
            {
                diasMes = 3;
            }
            else
            {
                diasMes = 2;
            }

            switch (diasMes)
            {
                case 1:
                    if (dia == 31)
                    {
               
                        dia = 1;
                        if (mes == "12")
                        {
                            año = año + 1;
                            mes = "1";
                        }
                        else
                        {
                            int numeroMes = System.Convert.ToInt32(mes);
                            numeroMes = numeroMes + 1;
                            mes = System.Convert.ToString(numeroMes);
                        }
                        
                    }
                    else if (dia > 31)
                    {
                        esValido = 0;
                    }
                    else
                    {
                        dia = dia + 1;
                    };
                    break;
                case 2:
                    if (dia == 30)
                    {
                        dia = 1;
                        int numeroMes = System.Convert.ToInt32(mes);
                        numeroMes = numeroMes + 1;
                        mes = System.Convert.ToString(numeroMes);
                    }
                    else if (dia > 30)
                    {
                        esValido = 0;
                    }
                    else
                    {
                        dia = dia + 1;
                    };
                    break;
                case 3:
                    if (dia == 28)
                    {
                        dia = 1;
                        int numeroMes = System.Convert.ToInt32(mes);
                        numeroMes = numeroMes + 1;
                        mes = System.Convert.ToString(numeroMes);
                    }
                    else if (dia > 28)
                    {
                        esValido = 0;
                    }
                    else
                    {
                        dia = dia + 1;
                    };
                    break;
                default:
                    break;
            }

            switch (mes)
            {
                case "1":
                    mes = "Enero";
                    break;
                case "2":
                    mes = "Febrero";
                    break;
                case "3":
                    mes = "Marzo";
                    break;
                case "4":
                    mes = "Abril";
                    break;
                case "5":
                    mes = "Mayo";
                    break;
                case "6":
                    mes = "Junio";
                    break;
                case "7":
                    mes = "Julio";
                    break;
                case "8":
                    mes = "Agosto";
                    break;
                case "9":
                    mes = "Septiembre";
                    break;
                case "10":
                    mes = "Octubre";
                    break;
                case "11":
                    mes = "Noviembre";
                    break;
                case "12":
                    mes = "Diciembre";
                    break;
                default:
                    break;
            }


            if (esValido == 1)
            {
                lblFecha.Text = "El día siguiente es " + dia + " de " + mes + " de " + año;
                lblFecha.Visible = true;
            }
            else
            {
                lblFecha.Text = "Fecha no válida";
                lblFecha.Visible = true;
            }
        }

        
}
}
