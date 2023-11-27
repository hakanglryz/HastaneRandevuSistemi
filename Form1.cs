using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş fr = new FrmSekreterGiriş(); 
            fr.Show();
            this.Hide();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş fr = new FrmDoktorGiriş();
            fr.Show();
            this.Hide();
        }
    }
}
