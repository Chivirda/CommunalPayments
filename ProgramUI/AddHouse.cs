using ProgramLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class AddHouse : Form
    {

        public House House { get; set; }

        public AddHouse()
        {
            InitializeComponent();
        }

        private void AddHouse_Load(object sender, EventArgs e)
        {

        }

        private void addHouseButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                House = new House()
                {
                    Name = textBoxName.Text
                };
                Close();
            }

            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
