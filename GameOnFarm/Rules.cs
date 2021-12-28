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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            label1.Text = "1. В залежності від вибору складності гравець має запам'ятати відповідне число тваринок за відведений час.";
            label2.Text = "2. Кількість тварин, різновид видів та час з кожним рівнем змінюються.";
            label3.Text = "3. Гравець може відповісти до завершення таймеру." +
                "\n\tПриємної гри :)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            AllForms.start.Visible = true;
        }

    }
}
