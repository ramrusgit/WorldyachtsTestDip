﻿using WorldyachtsBl.Model;
using System;
using System.Windows.Forms;

namespace WorldyachtsUI
{
    public partial class Login : Form
    {
        public Customer Customer { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        void loginBtn_Click(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = loginTxtBx.Text
            };
            DialogResult = DialogResult.OK;
        }
    }
}
