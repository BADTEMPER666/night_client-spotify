using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AnyDesk;
using Easy;
using Guna.UI2.WinForms;

namespace night_client
{
	// Token: 0x02000005 RID: 5
	public partial class Main : Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002120 File Offset: 0x00000320
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000229C File Offset: 0x0000049C
		private void leftclicker_Tick(object sender, EventArgs e)
		{
			try
			{
				this.leftclicker.Interval = 1000 / Convert.ToInt32((this.slider1.Value * 20f).ToString("0"));
				if (this.guna2CustomCheckBox1.Checked && Control.MouseButtons == MouseButtons.Left)
				{
					clickerclass.leftclick(1);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000212E File Offset: 0x0000032E
		private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.guna2CustomCheckBox1.Checked)
			{
				this.leftclicker.Start();
				return;
			}
			this.leftclicker.Stop();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002314 File Offset: 0x00000514
		private void slider1_MouseMove(object sender, MouseEventArgs e)
		{
			this.cpslabel.Text = ((this.slider1.Value * 20f).ToString("0.0") ?? "");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002154 File Offset: 0x00000354
		private void minimise_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000215D File Offset: 0x0000035D
		private void hide_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002165 File Offset: 0x00000365
		private void asdasd_Click(object sender, EventArgs e)
		{
			Process.Start("https://youtube.com/Nightbot");
			Process.Start("http://cheat.gq");
		}
	}
}
