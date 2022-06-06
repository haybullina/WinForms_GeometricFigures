using System;
using System.Drawing;

namespace WinForm_GeometricFigures
{
    [Serializable]
    class Rectangle : Figure
    {
        protected int widthF;
        protected int length;
        private Point B;
        private Point C;
        private Point D;   

        public void pointB(int x, int y)
        {
            B = new Point(x, y);
        }

        public void pointC(int x, int y)
        {
            C = new Point(x, y);
        }

        public void pointD(int x, int y)
        {
            D = new Point(x, y);
        }

        public Rectangle(Color color,int width) : base(color, width)
        {
        }
        
        public override void Draw(Graphics paper)
        {
            Pen pen = new Pen(color, width);
            length = Math.Abs(A.X - B.X);
            widthF = Math.Abs(A.Y - C.Y);
            paper.DrawRectangle(pen, A.X, A.Y, length, widthF);
        }
    }
}