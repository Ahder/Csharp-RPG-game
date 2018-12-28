using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Graphique
{
    public partial class StartingWindow : Form
    {
        public StartingWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreaPerso cin = new CreaPerso();
            cin.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
