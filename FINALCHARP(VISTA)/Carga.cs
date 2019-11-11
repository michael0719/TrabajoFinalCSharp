using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALCHARP_VISTA_
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
            reloj.Start();
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            pbcarga.Maximum = 10;
            if (pbcarga.Value < 10)
            {
                pbcarga.Increment(1);
            }
            else
            {
                reloj.Stop();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
