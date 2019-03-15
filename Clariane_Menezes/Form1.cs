using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroondasBLL;
using MicroondasModels;

namespace Clariane_Menezes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MicroondasBLL.Microondas testebll = new MicroondasBLL.Microondas();

            MicroondasModels.Aquecimento objAquecimento = new Aquecimento();

            
        }


    }
}
