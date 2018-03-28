using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2_dotnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuInventoryBrowse_Click(object sender, EventArgs e)
        {
            Form2 inventoryForm = new Form2();
            inventoryForm.ShowDialog();   
        }

        private void mnuFileProductsBrowser_Click(object sender, EventArgs e)
        {
           Form3 browserForm = new Form3();
           browserForm.ShowDialog();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            Form4 aboutForm = new Form4();
            aboutForm.ShowDialog();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
