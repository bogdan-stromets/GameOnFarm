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
    public partial class Game : Form
    {
        int time, numberOfAnimals;
        int [] animal_count;
      
        
        public Game()
        {
            InitializeComponent();
        }

        internal int Time
        {
            set { this.time = value; }
        }
        internal int NumOfAnimals
        {
            get { return numberOfAnimals; }
            set { this.numberOfAnimals = value; }
        }
        internal int[] Animal_count
        {
            get { return animal_count; }
        }


        internal void Draw()
        {
            
            PictureBox[] spawnPlaces =
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
                pictureBox12,
                pictureBox13,
                pictureBox14,
                pictureBox15,
                pictureBox16,
                pictureBox17,
                pictureBox18,
                pictureBox19,
                pictureBox20,
                pictureBox21,
                pictureBox22,
                pictureBox23,
                pictureBox24,
                pictureBox25,
                pictureBox26,
                pictureBox27
            };
        

            Random rand = new Random();
            int idx, animal_idx;

            List<int> prev_idx = new List<int>();

            if (AllForms.choose.Difficult == 1)
            {
                animal_count = new int[3];
                for (int i = 0; i < numberOfAnimals;)
                {
                    animal_idx = rand.Next(1, 25);
                    idx = rand.Next(0, 27);

                    if (!prev_idx.Contains(idx))
                    {
                        if (animal_idx % 3 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.chicken;
                            spawnPlaces[idx].Visible = true;
                            animal_count[0]++;
                        }
                        else if (animal_idx % 2 == 0 || animal_idx == 19)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.pig;
                            spawnPlaces[idx].Visible = true;
                            animal_count[1]++;
                        }
                        else
                        {
                            spawnPlaces[idx].Image = Properties.Resources.rabbit;
                            spawnPlaces[idx].Visible = true;
                            animal_count[2]++;
                        }
                        i++;
                        prev_idx.Add(idx);

                    }




                }



            }
            else if (AllForms.choose.Difficult == 2)
            {
                animal_count = new int[8];
                for (int i = 0; i < numberOfAnimals;)
                {
                    animal_idx = rand.Next(1, 25);
                    idx = rand.Next(0, 27);

                    if (!prev_idx.Contains(idx))
                    {
                        if (animal_idx % 7 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.chicken;
                            spawnPlaces[idx].Visible = true;
                            animal_count[0]++;
                        }
                        else if (animal_idx % 8 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.pig;
                            spawnPlaces[idx].Visible = true;
                            animal_count[1]++;
                        }
                        else if (animal_idx % 6 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.rabbit;
                            spawnPlaces[idx].Visible = true;
                            animal_count[2]++;
                        }
                        else if (animal_idx % 3 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.cow;
                            spawnPlaces[idx].Visible = true;
                            animal_count[3]++;
                        }
                        else if (animal_idx % 5 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.pig_green;
                            spawnPlaces[idx].Visible = true;
                            animal_count[4]++;
                        }
                        else if (animal_idx % 2 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.rabbit_blue;
                            spawnPlaces[idx].Visible = true;
                            animal_count[5]++;
                        }
                        else if (animal_idx == 19 || animal_idx == 13 || animal_idx == 23)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.cow_violet;
                            spawnPlaces[idx].Visible = true;
                            animal_count[6]++;
                        }
                        else
                        {
                            spawnPlaces[idx].Image = Properties.Resources.chick_round;
                            spawnPlaces[idx].Visible = true;
                            animal_count[7]++;
                        }
                        i++;
                        prev_idx.Add(idx);

                    }
                }

            }
            else if (AllForms.choose.Difficult == 3)
            {
                animal_count = new int[12];
                for (int i = 0; i < numberOfAnimals;)
                {
                    animal_idx = rand.Next(1, 25);
                    idx = rand.Next(0, 27);

                    if (!prev_idx.Contains(idx))
                    {
                        if (animal_idx % 12 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.chicken;
                            spawnPlaces[idx].Visible = true;
                            animal_count[0]++;
                        }
                        else if (animal_idx % 11 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.pig;
                            spawnPlaces[idx].Visible = true;
                            animal_count[1]++;
                        }
                        else if (animal_idx % 10 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.rabbit;
                            spawnPlaces[idx].Visible = true;
                            animal_count[2]++;
                        }
                        else if (animal_idx % 9 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.cow;
                            spawnPlaces[idx].Visible = true;
                            animal_count[3]++;
                        }
                        else if (animal_idx % 8 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.pig_green;
                            spawnPlaces[idx].Visible = true;
                            animal_count[4]++;
                        }
                        else if (animal_idx % 5 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.rabbit_blue;
                            spawnPlaces[idx].Visible = true;
                            animal_count[5]++;
                        }
                        else if (animal_idx == 1 || animal_idx == 21)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.cow_violet;
                            spawnPlaces[idx].Visible = true;
                            animal_count[6]++;
                        }
                        else if(animal_idx % 3 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.chick_round;
                            spawnPlaces[idx].Visible = true;
                            animal_count[7]++;
                        }
                        else if (animal_idx % 7 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.duck_sqare;
                            spawnPlaces[idx].Visible = true;
                            animal_count[8]++;
                        }
                        else if (animal_idx % 2 == 0)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.dog_sqare;
                            spawnPlaces[idx].Visible = true;
                            animal_count[9]++;
                        }
                        else if (animal_idx == 13 || animal_idx == 23)
                        {
                            spawnPlaces[idx].Image = Properties.Resources.goat_sqare;
                            spawnPlaces[idx].Visible = true;
                            animal_count[10]++;
                        }
                        else
                        {
                            spawnPlaces[idx].Image = Properties.Resources.parrot_sqare;
                            spawnPlaces[idx].Visible = true;
                            animal_count[11]++;
                        }
                        i++;
                        prev_idx.Add(idx);

                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time < 10 ? $"0:0{time}" : $"0:{time}";
            label1.Refresh();

            if (time == 0)
            {
                timer1.Enabled = false;
                label1.Text = "Час вийшов!";

                Controls.Clear();
               

                if (AllForms.answ == null)
                {
                    AllForms.answ = new Answers();
                    AllForms.answ.Show();
                }
                else
                {
                    AllForms.answ.Close();

                    AllForms.answ = new Answers();
                    AllForms.answ.Show();

                }

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "Час вийшов!";
            Controls.Clear();

            if (AllForms.answ == null)
            {
                AllForms.answ = new Answers();

                AllForms.answ.Show();
            }
            else
            {
                AllForms.answ.Close();

                AllForms.answ = new Answers();
                AllForms.answ.Show();

            }
            
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
