using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        
      
        private void valinta1_Click(object sender, EventArgs e)
        {
          
          Button painettunappi = sender as Button;
            string o = painettunappi.Text;
            switch (o)
            {
                case "Valinta1":
                    MessageBox.Show("Valinta1", "Huom");
                    break;
                case "Valinta2":
                    MessageBox.Show("Valinta2", "Huom");
                    break;
                case "Valinta3":
                    MessageBox.Show("Valinta3", "Huom");
                    break;
                case "Valinta4":
                    MessageBox.Show("Valinta4", "Huom");
                    break;
                case "Default":
                    MessageBox.Show("Default", "Huom");
                    break;

            }
        }

     

    }

      
    }
