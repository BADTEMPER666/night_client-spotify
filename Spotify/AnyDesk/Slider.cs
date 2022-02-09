using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnyDesk
{
	// Token: 0x02000004 RID: 4
	internal class Slider : Panel
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020BF File Offset: 0x000002BF
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020C7 File Offset: 0x000002C7
		public float Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.SetValue(value);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020D0 File Offset: 0x000002D0
		private void SetValue(float v)
		{
			if (v < 0f)
			{
				v = 0f;
			}
			else if (v > 1f)
			{
				v = 1f;
			}
			this.value = v;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020F9 File Offset: 0x000002F9
		public Slider()
		{
			this.brush = new SolidBrush(Color.FromArgb(160, 160, 160));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021DC File Offset: 0x000003DC
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.SetValue((float)e.Location.X / (float)base.Width);
				this.OnPaint(null);
			}
			base.OnMouseMove(e);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002224 File Offset: 0x00000424
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.g == null)
			{
				this.g = base.CreateGraphics();
			}
			this.g.Clear(this.BackColor);
			this.g.FillRectangle(new SolidBrush(Color.FromArgb(160, 160, 160)), 0f, 0f, (float)base.Width * this.value, (float)base.Height);
		}

		// Token: 0x04000004 RID: 4
		private float value;

		// Token: 0x04000005 RID: 5
		private Brush brush;

		// Token: 0x04000006 RID: 6
		private Graphics g;
	}
}
