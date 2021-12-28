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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }
        void GiveStars(double result)
        {
            if (result >= 90)
            {
                pictureBox1.Image = Properties.Resources.Stars;     
                pictureBox2.Image = Properties.Resources.Stars;
                pictureBox3.Image = Properties.Resources.Stars;
                

            }
            else if (result >= 50)
            {
                pictureBox1.Image = Properties.Resources.Stars;
                pictureBox2.Image = Properties.Resources.Stars;
                pictureBox3.Image = Properties.Resources.star2_removebg_preview;
            }
            else if (result >= 30)
            {
                pictureBox1.Image = Properties.Resources.Stars;
                pictureBox2.Image = Properties.Resources.star2_removebg_preview;
                pictureBox3.Image = Properties.Resources.star2_removebg_preview;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.star2_removebg_preview;
                pictureBox2.Image = Properties.Resources.star2_removebg_preview;
                pictureBox3.Image = Properties.Resources.star2_removebg_preview;
            }
        }
        private void Stats_Load(object sender, EventArgs e)
        {
            double result;
            if (AllForms.choose.Difficult == 1)
            {
                result = Math.Round((double)AllForms.answ.Correct_Count / 3 * 100);
                label1.Text = $"Ви правильно запам'ятали {result}% тварин";
                
            }
            else if (AllForms.choose.Difficult == 2)
            {
                result = Math.Round((double)AllForms.answ.Correct_Count / 8 * 100);
                label1.Text = $"Ви правильно запам'ятали {result}% тварин";
            }
            else
            {
                result = Math.Round((double)AllForms.answ.Correct_Count / 12 * 100);
                label1.Text = $"Ви правильно запам'ятали {result}% тварин";
            }
           
            
            GiveStars(result);

            AllForms.answ.Correct_Count = 0;
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            
            if (AllForms.start == null)
            {
                AllForms.start = new StartScreen();
                AllForms.start.Show();
            }
            else
            {

                AllForms.start.Show();
                AllForms.start.Visible = true;

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
