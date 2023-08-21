using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMartInventory.Forms
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			if (FrmLogin.LoginName != null)
			{
				LblUsername.Text = FrmLogin.LoginName;
			}
			if(FrmLogin.LoginType != null && FrmLogin.LoginType == "Sales")
			{
				userToolStripMenuItem.Enabled = false;
				productToolStripMenuItem.Enabled = false;
				categoryToolStripMenuItem.Enabled = false;
				userToolStripMenuItem.Visible = false;
				productToolStripMenuItem.Visible = false;
				categoryToolStripMenuItem.Visible = false;

			}
		}

		private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmCategory frmCategory = new FrmCategory();
			frmCategory.Show();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAbout frmAbout = new FrmAbout();
			frmAbout.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Do you really want to close this Application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if (dialog == DialogResult.No)
			{
				return;
			}
			else
			{
				Application.Exit();
			}
		}

		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Do you really want to close this Application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if(dialog == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				Application.Exit();
			}
		}

		private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void manageCashierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmSeller frmSeller = new FrmSeller();
			frmSeller.Show();
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAdmin frmAdmin = new FrmAdmin();
			frmAdmin.Show();
		}

		private void salesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAdmin frmAdmin = new FrmAdmin();
			frmAdmin.Show();
		}

		private void accountantToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAdmin frmAdmin = new FrmAdmin();
			frmAdmin.Show();
		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmProduct frmProduct = new FrmProduct();
			frmProduct.Show();
		}

		private void salesToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FrmSales frmSales = new FrmSales();
			frmSales.Show();
		}
	}
}
