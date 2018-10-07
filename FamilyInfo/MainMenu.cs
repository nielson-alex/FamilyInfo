using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyInfo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMomAndDad_Click(object sender, EventArgs e)
        {
            ScottAndKaren momAndDadForm = new ScottAndKaren();
            momAndDadForm.Tag = this;
            momAndDadForm.Show(this);
            Hide();
        }
    }
}
