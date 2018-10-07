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
    public partial class ScottAndKaren : Form
    {
        public ScottAndKaren()
        {
            InitializeComponent();

            string[] childrensNames = { "Jeremiah", "Benjamin", "Angel", "Eric", "Lisa", "Ryan", "Matt", "Alex" };
            string[] childrensSpouses = { "Courtney", "Janalee", "Jake", "Becky", "Gordon", "N/A", "Briette", "N/A" };
            int childCount = 8;

            for (int i = 0; i < childCount; i++)
            {
                Person person = new Person();
                person.FirstName = childrensNames[i];
                person.LastName = "Nielson";
                person.Spouse = childrensSpouses[i];

                Panel pnl = new Panel();
                ListBox list = new ListBox();
                
                Label lblFirstName = new Label();
                lblFirstName.Text = person.FirstName;
                Label lblLastName = new Label();
                lblLastName.Text = person.LastName;
                Label lblSpouse = new Label();
                lblSpouse.Text = person.Spouse;
                list.Items.Add(lblFirstName.Text);
                list.Items.Add(lblLastName.Text);
                list.Items.Add(lblSpouse.Text);
                pnl.Controls.Add(list);
                this.Controls.Add(pnl);
            }
        }
    }
}
