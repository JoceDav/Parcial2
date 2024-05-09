using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Tus datos se han guardado exitosamente!");
            //Nos muestra el mensaje de que nuestros datos han sido guardados correctamente. 
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            //Los textBox son las cajas de lso botones 
            //Clear como su mismo nombre lo dice, limpia/quita lo que se escribrio en esa caja de texto. 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear(); 
            textBox6.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Este cierra las ventanas y finaliza la ejecucion del programa. 
        }
    }
}
