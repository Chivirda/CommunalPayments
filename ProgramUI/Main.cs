﻿using ProgramLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            listHouses.DataSource = db.Houses.ToList();
            listHouses.DisplayMember = "Name";
            listHouses.ValueMember = "Id";

        }

        private void Main_Load(object sender, EventArgs e)
        {
            startDatePicker.Value = DateTime.Now.Date.AddDays(-(DateTime.Now.Day) + 1);
            endDatePicker.Value = DateTime.Now;
        }

        private void AddHouseButton_Click(object sender, EventArgs e)
        {
            AddHouse addHouse = new AddHouse();
            if (addHouse.ShowDialog() == DialogResult.OK)
            {
                db.Houses.Add(addHouse.House);
                db.SaveChanges();
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var HouseNames = db.Houses.Where(house => house.Name != null);
            foreach (var name in HouseNames)
            {
                richTextBoxResult.Text += $"Дом{name.Id}: {name.Name}\n";
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {

        }
    }
}
