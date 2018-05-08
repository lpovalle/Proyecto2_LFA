using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {

        string[] stn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LlenarDGV();

            Maquina5(0, 1);


        }

        public void LlenarDGV()
        {
            dgv.Rows.Clear();
            string input = tbxInput.Text;
            string[] vinput = new string[input.Length];
            dgv.Rows.Add(" ");

            for (int i = 0; i < input.Length; i++)
            {
                vinput[i] = input.Substring(i, 1);
                dgv.Rows.Add(vinput[i]);
            }

            dgv.Rows.Add(" ");
            stn = vinput;
        }

        public void Maquina5(int estado, int cabezal)
        {

            string head = null;

            if (dgv.Rows[cabezal].Cells[0].Value == null)
            {
                head = " ";
            }
            else
            {
                head = dgv.Rows[cabezal].Cells[0].Value.ToString();
            }

            switch (estado)
            {
                case 0:

                    dgv.Rows[cabezal].Cells[1].Value = "E0";

                    if (head == "1")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal++;
                    }
                    else if(head == "-")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "-";
                        cabezal++;
                    }
                    else if(head == null || head == " " || head == "")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;
                    }

                    Maquina5(estado, cabezal);

                    break;
                case 1:

                    dgv.Rows[cabezal].Cells[1].Value = "E1";
                    if (head == "1")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;
                    }
                    else if (head == "-")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }
                    else if (head == null || head == " ")
                    {
                         //no se puede
                    }

                    Maquina5(estado, cabezal);

                    break;
                case 2:

                    dgv.Rows[cabezal].Cells[1].Value = "E2";
                    if (head == "1")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;
                    }
                    else if (head == "-")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "-";
                        cabezal--;
                    }
                    else if (head == null || head == " ")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }

                    Maquina5(estado, cabezal);

                    break;
                case 3:

                    dgv.Rows[cabezal].Cells[1].Value = "E3";
                    if (head == "1")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }
                    else if (head == "-")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "-";
                        cabezal++;
                    }
                    else if (head == null || head == " ")
                    {
                        //no se puede
                    }

                    Maquina5(estado, cabezal);

                    break;
                case 4:

                    dgv.Rows[cabezal].Cells[1].Value = "E4";
                    break;
            }
        }
    }
}
