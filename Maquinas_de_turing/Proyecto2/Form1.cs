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

        private void button5_Click(object sender, EventArgs e)
        {
            LlenarDGV();
            Maquina4(0, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LlenarDGV();
            Maquina3(0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LlenarDGV();
            Maquina2(0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarDGV();
            Maquina1(0, 1);
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

        public void Maquina1(int estado, int cabezal)
        {
            string head = dgv.Rows[cabezal].Cells[0].Value.ToString();

            switch (estado)
            {
                case 0:
                    if (head == "a")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 8;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }

                    Maquina1(estado, cabezal);
                    break;
                case 1:
                    if (head == "a")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;

                    }

                    Maquina1(estado, cabezal);
                    break;
                case 2:

                    if (head == "a")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 7;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;

                    }

                    Maquina1(estado, cabezal);
                    break;
                case 3:
                    if (head == "a")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;

                    }

                    Maquina1(estado, cabezal);
                    break;
                case 4:
                    if(head == "a")
                    {
                        throw new Exception("No es palindromo");
                    }
                    else if(head == "b")
                    {
                        throw new Exception("No es palindromo");
                    }
                    else if (head == "c")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 8;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }

                    Maquina1(estado, cabezal);
                    break;
                case 5:
                    if (head == "a")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal--;

                    }
                    else if (head == "b")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal--;

                    }
                    else if (head == "c")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal--;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }

                    Maquina1(estado, cabezal);
                    break;
                case 6:
                    if (head == "a")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal--;

                    }
                    else if(head == "b")
                    {
                        throw new Exception("No es un palíndromo");
                    }
                    else if (head == "c")
                    {
                        throw new Exception("No es un palíndromo");
                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 8;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }

                    Maquina1(estado, cabezal);
                    break;
                case 7:
                    if (head == "a")
                    {
                        throw new Exception("No es un palíndromo");
                    }
                    else if (head == "b")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;

                    }
                    else if (head == "c")
                    {
                        throw new Exception("No es un palíndromo");
                    }

                    else if (head == "" || head == " ")
                    {
                        estado = 8;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }

                    Maquina1(estado, cabezal);
                    break;
                case 8:
                   // MessageBox.Show("Palindromo");
                    break;
                default:
                    break;
            }
        }

        public void Maquina2(int estado, int cabezal)
        {
            string head = dgv.Rows[cabezal].Cells[0].Value.ToString();

            switch(estado)
            {
                case 0:

                    if (head == "a")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "z";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal--;

                    }
                    else if (head == "x")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal++;

                    }
                    else if (head == "y")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal++;

                    }
                    else if (head == "z")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "z";
                        cabezal++;

                    }


                    Maquina2(estado, cabezal);
                    break;
                case 1:
                    if (head == "a")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal--;
                        dgv.Rows.Add(" ");

                    }
                    else if (head == "x")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal++;

                    }
                    else if (head == "y")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal++;

                    }
                    else if (head == "z")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "z";
                        cabezal++;

                    }

                    Maquina2(estado, cabezal);
                    break;
                case 2:
                    if (head == "a")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal--;
                        dgv.Rows.Add(" ");
                    }
                    else if (head == "x")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal++;

                    }
                    else if (head == "y")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal++;

                    }
                    else if (head == "z")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "z";
                        cabezal++;

                    }

                    Maquina2(estado, cabezal);
                    break;
                case 3:
                    if (head == "a")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal++;

                    }
                    else if (head == "b")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal++;

                    }
                    else if (head == "c")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal++;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "z";
                        cabezal--;
                        dgv.Rows.Add(" ");

                    }
                    else if (head == "x")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal++;

                    }
                    else if (head == "y")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal++;

                    }
                    else if (head == "z")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "z";
                        cabezal++;

                    }

                    Maquina2(estado, cabezal);
                    break;
                case 4:
                    if (head == "a")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal--;

                    }
                    else if (head == "b")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal--;

                    }
                    else if (head == "c")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal--;

                    }
                    else if (head == "" || head == " ")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }
                    else if (head == "x")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal--;

                    }
                    else if (head == "y")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal--;

                    }
                    else if (head == "z")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "z";
                        cabezal--;

                    }

                    Maquina2(estado, cabezal);
                    break;
                case 5:
                    if (head == "" || head == " ")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    }
                    else if (head == "x")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "a";
                        cabezal--;

                    }
                    else if (head == "y")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "b";
                        cabezal--;

                    }
                    else if (head == "z")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "c";
                        cabezal--;

                    }

                    Maquina2(estado, cabezal);
                    break;
                case 6:
                    break;

            }
        }

        public void Maquina3(int estado, int cabezal)
        {
            string head = dgv.Rows[cabezal].Cells[0].Value.ToString();

            switch(estado)
            {
                case 0:

                    if (head == "1")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal++;

                    }
                    else if (head == "*")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "*";
                        cabezal++;

                    }
                    else if (head == " " || head == null || head == "")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "=";
                        cabezal--;
                        dgv.Rows.Add(" ");
                    }
                    else if (head == "=")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "=";
                        cabezal--;
                    }
                    else if (head == "x")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal++;
                    }

                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);

                    break;
                case 1:
                    if (head == "1")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;

                    }
                    else if (head == "*")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "*";
                        cabezal--;

                    }
                    else if (head == " " || head == null || head == "")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }
                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);

                    break;
                case 2:
                    if (head == "1")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal--;

                    }
                    else if (head == "*")
                    {
                        estado = 8;
                        dgv.Rows[cabezal].Cells[0].Value = "*";
                        cabezal--;

                    }
                    else if (head == "x")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal--;
                    }
                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);

                    break;
                case 3:
                    if (head == "1")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;

                    }
                    else if (head == "*")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "*";
                        cabezal--;

                    }
                    else if (head == " " || head == null || head == "")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }
                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);

                    break;
                case 4:
                    if (head == "1")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal++;

                    }
                    else if (head == "*")
                    {
                        estado = 7;
                        dgv.Rows[cabezal].Cells[0].Value = "*";
                        cabezal--;

                    }
                    else if (head == "y")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal++;
                    }
                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);

                    break;
                case 5:
                    if (head == "1")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal++;

                    }
                    else if (head == "*")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "*";
                        cabezal++;

                    }
                    else if (head == " " || head == null || head == "")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;
                        dgv.Rows.Add(" ");
                    }
                    else if (head == "=")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "=";
                        cabezal++;
                    }
                    else if (head == "x")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal++;
                    }
                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);
                    break;
                case 6:
                    if (head == "1")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;

                    }
                    else if (head == "*")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = "*";
                        cabezal--;

                    }
                    else if (head == " " || head == null || head == "")
                    {
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }
                    else if (head == "=")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = "=";
                        cabezal--;
                    }
                    else if (head == "x")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = "x";
                        cabezal--;
                    }
                    else if (head == "y")
                    {
                        estado = 6;
                        dgv.Rows[cabezal].Cells[0].Value = "y";
                        cabezal--;
                    }
                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);
                    break;
                case 7:
                    if (head == " " || head == "" || head == null)
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }
                    else if (head == "y")
                    {
                        estado = 7;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;
                    }
                    else
                    {
                        throw new Exception("Símbolos incorrectos.");
                    }
                    Maquina3(estado, cabezal);
                    break;
                case 8:
                    break;
            }
        }

        public void Maquina4 (int estado, int cabezal)
        {
            string head = dgv.Rows[cabezal].Cells[0].Value.ToString();

            switch (estado)
            {
                case 0:

                    if (head == "1")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;

                    } else if (head == "+")
                    {
                        estado = 3;
                        dgv.Rows[cabezal].Cells[0].Value = "";
                        cabezal++;

                    } else if(head == " " || head == null || head == "")
                    {
                        //nada
                    }

                    Maquina4(estado, cabezal);
                    break;
                case 1:

                    if (head == "1")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal++;

                    }
                    else if (head == "+")
                    {
                        estado = 1;
                        dgv.Rows[cabezal].Cells[0].Value = "+";
                        cabezal++;

                    }
                    else if (head == " " || head == null || head == "")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;
                        dgv.Rows.Add(" ");
                    }
                    Maquina4(estado, cabezal);
                    break;
                case 2:

                    if (head == "1")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal--;

                    }
                    else if (head == "+")
                    {
                        estado = 2;
                        dgv.Rows[cabezal].Cells[0].Value = "+";
                        cabezal--;

                    }
                    else if (head == " " || head == null || head == "")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                        
                    }
                    Maquina4(estado, cabezal);
                    break;
                case 3:

                    break;
                default:
                    break;
            }


        }

        public void Maquina5 (int estado, int cabezal)
        {

            string head = dgv.Rows[cabezal].Cells[0].Value.ToString();

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
                        estado = 5;
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
                        estado = 4;
                        dgv.Rows[cabezal].Cells[0].Value = " ";
                        cabezal++;
                    }
                    else if (head == "-")
                    {
                        estado = 5;
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
                    if (head == "1")
                    {
                        estado = 0;
                        dgv.Rows[cabezal].Cells[0].Value = "1";
                        cabezal++;
                    }
                    else if (head == "-")
                    {
                        estado = 5;
                        dgv.Rows[cabezal].Cells[0].Value = "-";
                        cabezal--;
                    }
                    else if (head == null || head == " ")
                    {
                        //no se puede
                    }

                    Maquina5(estado, cabezal);
                    break;
                case 5:
                    break;
            }
        }


    }
}
