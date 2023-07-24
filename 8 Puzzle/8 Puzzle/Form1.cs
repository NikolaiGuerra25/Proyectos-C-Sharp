using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMov.Text = movimientos.ToString(); //para actualizar etiqueta que muestra la cantidad de movimentos
        }

        //BLOQUE DE VARIABLES

        // Varible que indican que botón ha sido presionado
        private bool boton1 = false;
        private bool boton2 = false;
        private bool boton3 = false;
        private bool boton4 = false;
        private bool boton5 = false;
        private bool boton6 = false;
        private bool boton7 = false;
        private bool boton8 = false;
        private bool boton9 = false;

        int movimientos = 0; //llevará un conteo de la cantidad de movimientos realizados en el juego

        private void btn1_Click(object sender, EventArgs e)
        {
            boton1 = true; // se ha presionado el botón 1
            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn1, btn2);
            Intercambio(btn1, btn4);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            //para cuando se quiere dejar un botón en blanco se redefine la text box
            if (txt1.Text == "")
            {
                txt1.Text = " ";
            }
            //botones
            if (btn1.Text == "")
            {
                btn1.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn2.Text == "")
            {
                btn2.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn3.Text == "")
            {
                btn3.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn4.Text == "")
            {
                btn4.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn5.Text == "")
            {
                btn5.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn6.Text == "")
            {
                btn6.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn7.Text == "")
            {
                btn7.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn8.Text == "")
            {
                btn8.Text = txt1.Text;
                txt1.Text = "";
            }

            if (btn9.Text == "")
            {
                btn9.Text = txt1.Text;
                txt1.Text = "";
            }
        }

        //FUNCIÓN DE INTERCAMBIOS
        //Método para realizar intercambio del botón presionado con el blanco

        public void Intercambio(Button origen, Button destino)
        {
            String aux; //Variable auxiliar para realizar el swap

            if (origen.Text != " ") // si el botón presionado es distinto de blanco 
            {
                if (destino.Text == " ") // si el botón destino es el blanco,  se realiza el cambio de botones
                {
                    aux = origen.Text;
                    origen.Text = " ";
                    destino.Text = aux;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            boton2 = true; // se ha presionado el botón 2

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn2, btn1);
            Intercambio(btn2, btn3);
            Intercambio(btn2, btn5);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            boton3 = true; // se ha presionado el botón 3
            Intercambio(btn3, btn6);
            Intercambio(btn3, btn2);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            boton4 = true; // se ha presionado el botón 4

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn4, btn1);
            Intercambio(btn4, btn5);
            Intercambio(btn4, btn7);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            boton5 = true; // se ha presionado el botón 5

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn5, btn2);
            Intercambio(btn5, btn4);
            Intercambio(btn5, btn6);
            Intercambio(btn5, btn8);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            boton6 = true; // se ha presionado el botón 6

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn6, btn3);
            Intercambio(btn6, btn5);
            Intercambio(btn6, btn9);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            boton7 = true; // se ha presionado el botón 7

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn7, btn4);
            Intercambio(btn7, btn8);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            boton8 = true; // se ha presionado el botón 8

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn8, btn5);
            Intercambio(btn8, btn7);
            Intercambio(btn8, btn9);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            boton9 = true; // se ha presionado el botón 9

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = movimientos.ToString();

            Intercambio(btn9, btn6);
            Intercambio(btn9, btn8);

            //ganó?

            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" &&
                btn4.Text == "8" && btn5.Text == " " && btn6.Text == "4" &&
                btn7.Text == "7" && btn8.Text == "6" && btn9.Text == "5")
            {
                MessageBox.Show(" GANASTE ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblMov_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
