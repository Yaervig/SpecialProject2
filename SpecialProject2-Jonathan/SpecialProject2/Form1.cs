using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpecialProject2
{
    public partial class Form1 : Form
    {
        Art art = new Art();
        Pen pen = new Pen(Color.Black, 2);

        Bitmap bm;
        Graphics g;


        public Form1()
        {
            InitializeComponent();

            bm = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            canvas.Image = bm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbX.Text, out var input))
                art.setButtonDrawX(int.Parse(tbX.Text));
        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbY.Text, out var input))
                art.setButtonDrawY(int.Parse(tbY.Text));
        }
        private void tbLength_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbLength.Text, out var input))
                art.setLength(int.Parse(tbLength.Text));
        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbHeight.Text, out var input))
                art.setHeight(int.Parse(tbHeight.Text));
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            switch (art.getDrawMode())
            {
                case 0: //nothing
                    break;
                case 1: //rectangle
                    g.DrawRectangle(pen, art.getButtonDrawX(), art.getButtonDrawY(), art.getLength(), art.getHeight());
                    canvas.Refresh();
                    break;
                case 2: //circle
                    break;
                case 3: //triangle
                    break;
                case 4: //line
                    break;
            }
        }

        private void cbModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - nothing
            // 1 - rectangle
            // 2 - circle
            // 3 - triangle
            // 4 - line
            art.setDrawMode(cbModeSelect.SelectedIndex + 1);
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = colorDialog.Color;
                }
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            art.setMouseDrawX1(e.X);
            art.setMouseDrawY1(e.Y);
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            art.setMouseDrawX2(e.X);
            art.setMouseDrawY2(e.Y);

            int x1 = art.getMouseDrawX1();
            int x2 = art.getMouseDrawX2();
            int y1 = art.getMouseDrawY1();
            int y2 = art.getMouseDrawY2();

            switch (art.getDrawMode())
            {
                case 0: //nothing
                    break;
                case 1: //rectangle
                    g.DrawRectangle(pen, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                    canvas.Refresh();
                    break;
                case 2: //circle
                    break;
                case 3: //triangle
                    break;
                case 4: //line
                    break;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}

