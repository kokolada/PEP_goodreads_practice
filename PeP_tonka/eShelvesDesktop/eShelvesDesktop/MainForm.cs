﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShelvesDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void novaKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddKnjiga frm = new AddKnjiga();
            frm.MdiParent = this;
            frm.Show();
        }

        private void manageKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageKnjigas frm = new ManageKnjigas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddKorisnik frm = new AddKorisnik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void manageKorisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageKorisniks frm = new ManageKorisniks();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
