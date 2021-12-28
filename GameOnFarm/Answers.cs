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
    public partial class Answers : Form
    {
        int correct_count;
        int[] player_answ;
        TextBox[] alltext;

        public Answers()
        {
            InitializeComponent();
            TextBox[] temp =
            {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8,
                textBox9,
                textBox10,
                textBox11,
                textBox12
            };
            alltext = temp;

            CheckDiff();
        }
        internal int Correct_Count
        {
            get { return correct_count; }
            set { correct_count = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < player_answ.Length; i++)
            {
                alltext[i].Enabled = false;
            }
            
            CheckAnswers();
            button1.Enabled = false;

            button2.Visible = true;
            
            
        }
        void CheckDiff()
        {


            PictureBox[] allbox =
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10,
                pictureBox11,
                pictureBox12
            };

            if (AllForms.choose.Difficult == 1)
            {
                player_answ = new int[3];
            }
            else if (AllForms.choose.Difficult == 2)
            {
                player_answ = new int[8];
            }
            else
            {
                player_answ = new int[12];
            }

            for (int i = 0; i < player_answ.Length; i++)
            {
                allbox[i].Visible = true;
                alltext[i].Visible = true;
            }
        }

        void CheckAnswers()
        {
            PictureBox[] correctOrnot =
            {
                correct1,
                correct2,
                correct3,
                correct4,
                correct5,
                correct6,
                correct7,
                correct8,
                correct9,
                correct10,
                correct11,
                correct12
            };

            for (int i = 0; i < player_answ.Length; i++)
            {
                if (AllForms.game.Animal_count[i] == player_answ[i])
                {
                    correctOrnot[i].SizeMode = PictureBoxSizeMode.Zoom;
                    correctOrnot[i].Image = Properties.Resources.Correct;
                    correctOrnot[i].Visible = true;
                    correct_count++;
                }
                else
                {
                    correctOrnot[i].SizeMode = PictureBoxSizeMode.Zoom;
                    correctOrnot[i].Image = Properties.Resources.not;
                    correctOrnot[i].Visible = true;
                }

            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int count = AllForms.game.NumOfAnimals;
            int sum = 0;

            for (int i = 0; i < player_answ.Length; i++)
            {
                if (!(alltext[i].Text == String.Empty))
                {
                    try
                    {
                        player_answ[i] = int.Parse(alltext[i].Text);
                        sum += player_answ[i];
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введено недопустимий символ!");
                        alltext[i].Text = "0";
                    }
                }

                
            }

            count -= sum;
            label2.Text = count >= 0 ? $"Тварин залишилося: {count}" : "Введено кількість більшу за можливу!";
            label2.Visible = true;
        }
        private void textBox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < player_answ.Length; i++)
            {
                if (alltext[i].Text == "0")
                    alltext[i].SelectAll();

            }
        }

        private void Answers_Load(object sender, EventArgs e)
        {
            AllForms.game.Visible = false;
            for (int i = 0; i < player_answ.Length; i++)
            {
                alltext[i].Visible = true;
                if (alltext[i].Text == string.Empty)
                {
                    alltext[i].Text = "0";
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Visible = false;
            if (AllForms.stats == null)
            {

                AllForms.stats = new Stats();
                AllForms.stats.Show();
            }
            else
            {
                AllForms.stats.Close();

                AllForms.stats = new Stats();
                AllForms.stats.Show();

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
