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
    public partial class Main : Form
    {
        CPContext db;

        public Main()
        {
            InitializeComponent();
            db = new CPContext();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addHouseButton_Click(object sender, EventArgs e)
        {
            AddHouse addHouse = new AddHouse();
            addHouse.Show();
        }
    }
}
