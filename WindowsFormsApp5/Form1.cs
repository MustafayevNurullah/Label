using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void QacanLabel_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            QacanLabel.Top = random.Next(0, 400 - QacanLabel.Height);
            QacanLabel.Left = random.Next(0, 400 - QacanLabel.Width);
        }
    }
}
