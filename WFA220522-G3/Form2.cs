using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220522_G3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public Color secilenRenk;
       
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Color.AliceBlue);
            comboBox1.Items.Add(Color.Red);
            comboBox1.Items.Add(Color.Yellow);
            comboBox1.Items.Add(Color.Olive);
            comboBox1.Items.Add(Color.Orange);
            comboBox1.Items.Add(Color.Black);
            comboBox1.Items.Add(Color.HotPink);
            comboBox1.Items.Add(Color.Purple);
            comboBox1.Items.Add(Color.Gray);

            comboBox1.SelectedIndex = 0;

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {

            secilenRenk = (Color)comboBox1.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
