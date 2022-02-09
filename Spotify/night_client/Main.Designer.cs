namespace night_client
{
	// Token: 0x02000005 RID: 5
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000217D File Offset: 0x0000037D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002354 File Offset: 0x00000554
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::night_client.Main));
			this.rightclicker = new global::System.Windows.Forms.Timer(this.components);
			this.leftclicker = new global::System.Windows.Forms.Timer(this.components);
			this.cpslabel2 = new global::System.Windows.Forms.Label();
			this.cpslabel = new global::System.Windows.Forms.Label();
			this.guna2CustomCheckBox1 = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.minimise = new global::Guna.UI2.WinForms.Guna2Button();
			this.hide = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Elipse2 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.asdasd = new global::System.Windows.Forms.Label();
			this.slider1 = new global::AnyDesk.Slider();
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			base.SuspendLayout();
			this.leftclicker.Tick += new global::System.EventHandler(this.leftclicker_Tick);
			this.cpslabel2.AutoSize = true;
			this.cpslabel2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.cpslabel2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.cpslabel2.ForeColor = global::System.Drawing.Color.White;
			this.cpslabel2.Location = new global::System.Drawing.Point(827, 681);
			this.cpslabel2.Name = "cpslabel2";
			this.cpslabel2.Size = new global::System.Drawing.Size(28, 13);
			this.cpslabel2.TabIndex = 41;
			this.cpslabel2.Text = "3:26";
			this.cpslabel.AutoSize = true;
			this.cpslabel.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.cpslabel.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cpslabel.ForeColor = global::System.Drawing.Color.White;
			this.cpslabel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.cpslabel.Location = new global::System.Drawing.Point(344, 681);
			this.cpslabel.Name = "cpslabel";
			this.cpslabel.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.cpslabel.Size = new global::System.Drawing.Size(28, 13);
			this.cpslabel.TabIndex = 39;
			this.cpslabel.Text = "0:00";
			this.cpslabel.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.guna2CustomCheckBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CustomCheckBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.guna2CustomCheckBox1.CheckedState.BorderColor = global::System.Drawing.Color.Lime;
			this.guna2CustomCheckBox1.CheckedState.BorderRadius = 18;
			this.guna2CustomCheckBox1.CheckedState.BorderThickness = 1;
			this.guna2CustomCheckBox1.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2CustomCheckBox1.CheckedState.Parent = this.guna2CustomCheckBox1;
			this.guna2CustomCheckBox1.CheckMarkColor = global::System.Drawing.Color.Transparent;
			this.guna2CustomCheckBox1.Location = new global::System.Drawing.Point(582, 642);
			this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
			this.guna2CustomCheckBox1.ShadowDecoration.Parent = this.guna2CustomCheckBox1;
			this.guna2CustomCheckBox1.Size = new global::System.Drawing.Size(34, 34);
			this.guna2CustomCheckBox1.TabIndex = 35;
			this.guna2CustomCheckBox1.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 0;
			this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
			this.guna2CustomCheckBox1.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2CustomCheckBox1.UncheckedState.Parent = this.guna2CustomCheckBox1;
			this.guna2CustomCheckBox1.CheckedChanged += new global::System.EventHandler(this.guna2CustomCheckBox1_CheckedChanged);
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.pictureBox1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.pictureBox1.Location = new global::System.Drawing.Point(315, 681);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(61, 17);
			this.pictureBox1.TabIndex = 55;
			this.pictureBox1.TabStop = false;
			this.pictureBox3.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.pictureBox3.Location = new global::System.Drawing.Point(823, 681);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(61, 17);
			this.pictureBox3.TabIndex = 56;
			this.pictureBox3.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(1144, -14);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(29, 17);
			this.label1.TabIndex = 60;
			this.label1.Text = "Rec";
			this.minimise.BackColor = global::System.Drawing.Color.Transparent;
			this.minimise.CheckedState.Parent = this.minimise;
			this.minimise.CustomImages.Parent = this.minimise;
			this.minimise.FillColor = global::System.Drawing.Color.Transparent;
			this.minimise.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.minimise.ForeColor = global::System.Drawing.Color.White;
			this.minimise.HoverState.Parent = this.minimise;
			this.minimise.Location = new global::System.Drawing.Point(1062, 0);
			this.minimise.Name = "minimise";
			this.minimise.PressedColor = global::System.Drawing.Color.White;
			this.minimise.ShadowDecoration.Color = global::System.Drawing.Color.White;
			this.minimise.ShadowDecoration.Parent = this.minimise;
			this.minimise.Size = new global::System.Drawing.Size(44, 31);
			this.minimise.TabIndex = 61;
			this.minimise.Click += new global::System.EventHandler(this.minimise_Click);
			this.hide.BackColor = global::System.Drawing.Color.Transparent;
			this.hide.CheckedState.Parent = this.hide;
			this.hide.CustomImages.Parent = this.hide;
			this.hide.FillColor = global::System.Drawing.Color.Transparent;
			this.hide.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.hide.ForeColor = global::System.Drawing.Color.White;
			this.hide.HoverState.Parent = this.hide;
			this.hide.Location = new global::System.Drawing.Point(1151, 0);
			this.hide.Name = "hide";
			this.hide.PressedColor = global::System.Drawing.Color.Red;
			this.hide.ShadowDecoration.Color = global::System.Drawing.Color.White;
			this.hide.ShadowDecoration.Parent = this.hide;
			this.hide.Size = new global::System.Drawing.Size(50, 31);
			this.hide.TabIndex = 63;
			this.hide.Click += new global::System.EventHandler(this.hide_Click);
			this.guna2Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Location = new global::System.Drawing.Point(1111, 0);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.PressedColor = global::System.Drawing.Color.White;
			this.guna2Button2.ShadowDecoration.Color = global::System.Drawing.Color.White;
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(38, 31);
			this.guna2Button2.TabIndex = 64;
			this.guna2Elipse2.BorderRadius = 4;
			this.asdasd.AutoSize = true;
			this.asdasd.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.asdasd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.asdasd.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.asdasd.ForeColor = global::System.Drawing.Color.LightGray;
			this.asdasd.Location = new global::System.Drawing.Point(11, 673);
			this.asdasd.Name = "asdasd";
			this.asdasd.Size = new global::System.Drawing.Size(204, 17);
			this.asdasd.TabIndex = 65;
			this.asdasd.Text = "Spotify FREE | cheat.gq | Nightbot";
			this.asdasd.Click += new global::System.EventHandler(this.asdasd_Click);
			this.slider1.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.slider1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.slider1.ForeColor = global::System.Drawing.Color.Transparent;
			this.slider1.Location = new global::System.Drawing.Point(381, 685);
			this.slider1.Name = "slider1";
			this.slider1.Size = new global::System.Drawing.Size(433, 6);
			this.slider1.TabIndex = 29;
			this.slider1.Value = 0f;
			this.slider1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.slider1_MouseMove);
			this.guna2Elipse1.BorderRadius = 3;
			this.guna2Elipse1.TargetControl = this.slider1;
			base.AccessibleName = "";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(1194, 704);
			base.Controls.Add(this.asdasd);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.hide);
			base.Controls.Add(this.minimise);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.slider1);
			base.Controls.Add(this.guna2CustomCheckBox1);
			base.Controls.Add(this.cpslabel2);
			base.Controls.Add(this.cpslabel);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.pictureBox3);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Spotify (32 bit)";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000008 RID: 8
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000009 RID: 9
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Timer rightclicker;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Timer leftclicker;

		// Token: 0x0400000C RID: 12
		private global::AnyDesk.Slider slider1;

		// Token: 0x0400000D RID: 13
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label cpslabel2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label cpslabel;

		// Token: 0x04000010 RID: 16
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000014 RID: 20
		private global::Guna.UI2.WinForms.Guna2Button minimise;

		// Token: 0x04000015 RID: 21
		private global::Guna.UI2.WinForms.Guna2Button hide;

		// Token: 0x04000016 RID: 22
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label asdasd;
	}
}
