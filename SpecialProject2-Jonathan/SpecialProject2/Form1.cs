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
        SolidBrush brush = new SolidBrush(Color.Black);

        Bitmap bm;
        Graphics g;

        bool isClicked = false;


        public Form1()
        {
            InitializeComponent();

            bm = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(bm);
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
            int x = art.getButtonDrawX();
            int y = art.getButtonDrawY();
            int l = art.getLength();
            int h = art.getHeight();

            switch (art.getDrawMode())
            {
                case 0: //rectangle
                    if (art.getFill() == false)
                        g.DrawRectangle(pen, x, y, l, h);
                    else
                        g.FillRectangle(brush, x, y, l, h);
                    canvas.Refresh();
                    break;
                case 1: //ellipse
                    if (art.getFill() == false)
                        g.DrawEllipse(pen, x, y, l, h);
                    else
                        g.FillEllipse(brush, x, y, l, h);
                    canvas.Refresh();
                    break;
                case 2: //triangle
                    Point[] tri = new Point[3]
                    {
                       new Point{X = x + l / 2, Y = y},
                       new Point{X = x, Y = y + h},
                       new Point{X = x + l, Y = y + h}
                    };

                    if (art.getFill() == false)
                        g.DrawPolygon(pen, tri);
                    else
                        g.FillPolygon(brush, tri);
                    canvas.Refresh();
                    break;
                case 3: //line
                    g.DrawLine(pen, x, y, x + l, y + h);
                    canvas.Refresh();
                    break;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            canvas.Refresh();
        }

        private void cbModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - rectangle
            // 1 - ellipse
            // 2 - triangle
            // 3 - line
            // 4 - free draw
            art.setDrawMode(cbModeSelect.SelectedIndex);
        }

        private void cbFillSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFillSelect.SelectedIndex == 0)
                art.setFill(false);
            else
                art.setFill(true);
        }

        private void cbThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.Width = (float)cbThickness.SelectedIndex + 1;
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = colorDialog.Color;
                    brush.Color = colorDialog.Color;
                }
            }
        }

        private void bEraser_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            brush.Color = Color.White;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;

            art.setMouseDrawX1(e.X);
            art.setMouseDrawY1(e.Y);
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

            art.setMouseDrawX2(e.X);
            art.setMouseDrawY2(e.Y);

            int x1 = art.getMouseDrawX1();
            int x2 = art.getMouseDrawX2();
            int y1 = art.getMouseDrawY1();
            int y2 = art.getMouseDrawY2();

            switch (art.getDrawMode())
            {
                case 0: //rectangle
                    if(art.getFill() == false)
                        g.DrawRectangle(pen, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                    else
                        g.FillRectangle(brush, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                    canvas.Refresh();
                    break;
                case 1: //ellipse
                    if (art.getFill() == false)
                        g.DrawEllipse(pen, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                    else
                        g.FillEllipse(brush, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                    canvas.Refresh();
                    break;
                case 2: //triangle
                    Point[] tri = new Point[3]
                    {
                       new Point{X = (x1 + x2) / 2, Y = y1},
                       new Point{X = x1, Y = y2},
                       new Point{X = x2, Y = y2}
                    };

                    if (art.getFill() == false)
                        g.DrawPolygon(pen, tri);
                    else
                        g.FillPolygon(brush, tri);
                    canvas.Refresh();
                    break;
                case 3: //line
                    g.DrawLine(pen, x1, y1, x2, y2);
                    canvas.Refresh();
                    break;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked == true && art.getDrawMode() == 4)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                art.setMouseDrawX2(e.X);
                art.setMouseDrawY2(e.Y);
                g.DrawLine(pen, art.getMouseDrawX1(), art.getMouseDrawY1(), art.getMouseDrawX2(), art.getMouseDrawY2());
                art.setMouseDrawX1(art.getMouseDrawX2());
                art.setMouseDrawY1(art.getMouseDrawY2());

                canvas.Refresh();
            }
        }

    }
}

