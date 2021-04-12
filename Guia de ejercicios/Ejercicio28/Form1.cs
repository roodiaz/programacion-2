using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();         
        }
        public static int OrdenarPorValor(KeyValuePair<string, int> palabraSigiente, KeyValuePair<string, int> palabraActual)
        {
            if (palabraActual.Value > palabraSigiente.Value)
                return 1;
            else if (palabraActual.Value < palabraSigiente.Value)
                return -1;
            else
                return 0;

        }

        public void CalculoPalabras()
        {
            Dictionary<string, int> palabrasDic = new Dictionary<string, int>();
            string texto = this.richTextBox.Text;
            string[] palabras; //declaro string de palabras para guardar
            palabras = texto.Split(' ');//defino que las palabras del texro estan separadas por un espacio y guardo

            //recorro string palabras
            foreach (string item in palabras)
            {
                if (!palabrasDic.ContainsKey(item))
                    palabrasDic.Add(item, 1);
                /*sino se encuentra palarabe en el diccionario la agrego e
                 * inicializo su contador en 1*/
                else
                    palabrasDic[item]++;//aumentar el value en 1
            }

            List<KeyValuePair<string, int>> repeticiones =palabrasDic.ToList();
            repeticiones.Sort(OrdenarPorValor);

            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show($"Palabra mas repetida {repeticiones[i].Key} , veces: {repeticiones[i].Value}");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculoPalabras();   
                    
        }

       
    }
}
