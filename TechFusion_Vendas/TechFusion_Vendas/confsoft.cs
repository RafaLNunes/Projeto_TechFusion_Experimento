﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup2
{
    public partial class confsoft : Form
    {
        public confsoft(Classe_produto produto)
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void confsoft_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comprasoft comprasoft = new comprasoft();
            this.Hide();
            comprasoft.ShowDialog();
        }

        private void confsoft_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}