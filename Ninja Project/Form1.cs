﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninja_Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == WM_NCHITTEST)
				m.Result = (IntPtr)(HT_CAPTION);
		}

		private const int WM_NCHITTEST = 0x84;
		private const int HT_CLIENT = 0x1;
		private const int HT_CAPTION = 0x2;

		private void guna2Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
	
		}

		private void guna2HtmlLabel1_Click(object sender, EventArgs e)
		{

		}

		private void guna2HtmlLabel8_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}


