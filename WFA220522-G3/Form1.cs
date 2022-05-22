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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            //frm2.Show();
            if (frm2.ShowDialog()==DialogResult.OK)
            {
                this.BackColor = frm2.secilenRenk;
            }
        }       
    }
}
