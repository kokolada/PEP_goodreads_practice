using eShelvesDesktop.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShelvesDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebApiHelper h = new WebApiHelper("http://hci111.app.fit.ba/api/", "Korisniks?id=1");
            HttpResponseMessage response = h.GetResponse();
            label1.Text = response.Content.ReadAsStringAsync().Result.ToString();
        }
    }
}
