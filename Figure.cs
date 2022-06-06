using System;
using System.Drawing;

namespace WinForm_GeometricFigures
{
    [Serializable]
    abstract class Figure
    {
        protected Color color;
        protected int width;
        protected Point A;

        public void pointA(int x, int y)
        {
            A = new Point(x, y);
        }

        public Figure(Color color, int width)
        {
            this.color = color;
            this.width = width;
        }

        public virtual void Draw(Graphics paper)
        {
        }
    }
}