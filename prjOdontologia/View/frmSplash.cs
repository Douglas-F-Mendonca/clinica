﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjOdontologia
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pbCarrega_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pbCarrega.Value < 100)
            {
                pbCarrega.Value = pbCarrega.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                FrmLogin frml = new FrmLogin();
                frml.Show();
            }
        }
    }
}
