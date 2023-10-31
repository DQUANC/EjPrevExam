using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPrevExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Ejercicio #1
        private void button1_Click(object sender, EventArgs e)
        {
            String num = textBox1.Text;
            label1.Text = cond(num);
        }

            // Function
        
        public string cond (string num)
        {
            string res = "";
            int conv = num.Length;

            if (conv == 7)
            {
                res = label1.Text + "El numero es local";
            } else if (conv == 9)
            {
                res = label1.Text + "El numero es movil";
            } else if (conv >= 9)
            {
                res = label1.Text + "El numero es Internacional";
            }
            else
            {
                res = label1.Text + "El numero no es valido";
            }
            
            return res; 
        }

        // Ejercicio #2
        private void button2_Click(object sender, EventArgs e)
        {
            string keyWord = textBox2.Text;
            label2.Text = ValIng(keyWord);
        }

            // Function
             
        public string ValIng (string value)
        {
            string val = "";

            if ( value == "A" ||  value == "E" || value == "I" || value == "O" || value == "U")
            {
                val = label2.Text + "La tecla ingresada es una vocal";
            } else
            {
                val = label2.Text + "La tecla ingresada es una consonante o un caracter especial";
            }

            return val;
        }

        // Ejercicio #3
        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int num = 100;

            while (num <= 200)
            {
                sum += num;
                num++;

                label3.Text = "La suma es: " + sum;
            }
        }

        // Ejercicio #4
        private void button4_Click(object sender, EventArgs e)
        {
            int cont = 10;
            label4.Text = " ";

            while (cont >= 1)
            {
                label4.Text = label4.Text + " - " + cont + " - ";
                cont--;
            }
            
        }

        // Ejercicio #5
        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox3.Text);
            int num2 = Convert.ToInt32(textBox4.Text);

            int x = num1;
            while (x <= num2)
            {
                if (x % 2 == 0)
                {
                    label5.Text = label5.Text + " - " + x;
                }
                x++;
            }
        }

        // Ejercicio #6
        private void button6_Click(object sender, EventArgs e)
        {
            int pts = Convert.ToInt32(textBox5.Text);

            if (pts <= 60 && pts >= 0)
            {
                label6.Text = label6.Text + " Inaceptable.";
            } else if (pts >= 61 &&  pts <= 80)
            {
                label6.Text = label6.Text + " Aceptable.";
            } else if (pts >= 81 && pts <= 100)
            {
                label6.Text = label6.Text + " Meritorio.";
            } else
            {
                label6.Text = label6.Text + " no valida.";
            }
        }

        /*
        Ej 1
        Crea un programa que te permita ingresar un número de teléfono y te devuelva que tipo
        de teléfono es, según las siguientes condiciones
        Si tiene 7 dígitos, es fijo o local, 9 dígitos es móvil, más de 9 dígitos es número internacional
        Ej 2
        Crea un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal o
        consonante
        Ej 3
        Cree un bucle que sume los números del 100 al 200
        Ej 4
        Imprima los números del 1 a 10 al revés utilizando el ciclo for
        Ej 5
        Realiza un programa en C#, que permita ingresar 2 números enteros, e imprima los números
        pares que existen entre los 2.
        Ej 6
        Realiza un programa en C#, que permita por medio de un textbox ingresar la puntuación de
        un empleado y nos pueda retornar el nivel con respecto al rango en el que se encuentra:
        Inaceptable 0 – 60
        Aceptable 60 - 80
        Meritorio 80 – 100
        */
    }
}
