using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOnFarm
{
    public partial class StartScreen : Form
    {

        public StartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
           
            if (AllForms.choose == null)
            {
                AllForms.choose = new ChooseDifficult();
                AllForms.choose.Show();
            }
            else
            {
                AllForms.choose.Show();
                AllForms.choose.Visible = true;    
            }  
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            AllForms.rules = new Rules();
            AllForms.rules.Show(); 
        }
    }
}
