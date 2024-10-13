using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialProject2
{
    internal class Art
    {
        private Point buttonDraw;
        private Point mouseDraw1;
        private Point mouseDraw2;
        private int length;
        private int height;
        private int drawMode;

        public Art()
        {
            setButtonDrawX(100);
            setButtonDrawY(100);
            setLength(100);
            setHeight(100);
            setDrawMode(0);
        }

        public void setButtonDrawX(int val)
        {
            buttonDraw.X = val;
        }

        public int getButtonDrawX()
        {
            return buttonDraw.X;
        }

        public void setButtonDrawY(int val)
        {
            buttonDraw.Y = val;
        }

        public int getButtonDrawY()
        {
            return buttonDraw.Y;
        }



        public void setMouseDrawX1(int val)
        {
            mouseDraw1.X = val;
        }

        public int getMouseDrawX1()
        {
            return mouseDraw1.X;
        }

        public void setMouseDrawY1(int val)
        {
            mouseDraw1.Y = val;
        }

        public int getMouseDrawY1()
        {
            return mouseDraw1.Y;
        }

        public void setMouseDrawX2(int val)
        {
            mouseDraw2.X = val;
        }

        public int getMouseDrawX2()
        {
            return mouseDraw2.X;
        }

        public void setMouseDrawY2(int val)
        {
            mouseDraw2.Y = val;
        }

        public int getMouseDrawY2()
        {
            return mouseDraw2.Y;
        }



        public void setLength(int val)
        {
            length = val;
        }

        public int getLength()
        {
            return length;
        }

        public void setHeight(int val)
        {
            height = val;
        }

        public int getHeight()
        {
            return height;
        }

        public void setDrawMode(int val)
        {
            drawMode = val;
        }

        public int getDrawMode()
        {
            return drawMode;
        }
    }
}
