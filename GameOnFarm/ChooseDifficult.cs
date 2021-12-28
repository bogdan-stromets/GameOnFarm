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
    public partial class ChooseDifficult : Form
    {
        int diff;
        public ChooseDifficult()
        {
            InitializeComponent();
        }

        internal int Difficult
        {
            get { return diff; }
        }
        void ChooseDiff(int time, int numOfAnimals)
        {
            Visible = false;
            
            if (AllForms.game == null)
            {
                AllForms.game = new Game();
                AllForms.game.Time = time;
                AllForms.game.NumOfAnimals = numOfAnimals;
                AllForms.game.Draw();
                AllForms.game.Show();
            }
            else
            {
                AllForms.game.Close();

                AllForms.game = new Game();
                AllForms.game.Time = time;
                AllForms.game.NumOfAnimals = numOfAnimals;
                AllForms.game.Draw();
                AllForms.game.Show();

            }
            
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            diff = 1;
            ChooseDiff(10,5);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diff = 2;
            ChooseDiff(15,10);
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            diff = 3;
            ChooseDiff(20,15);
            
        }
    }
}
