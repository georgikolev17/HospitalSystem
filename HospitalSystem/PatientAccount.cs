﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem
{
    public partial class PatientAccount : Form
    {
        public PatientAccount()
        {
            InitializeComponent();
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var appointment = new Appointments();
            appointment.ShowDialog();
            this.Close();
        }
    }
}
