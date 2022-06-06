using System;
using System.Drawing;

namespace WinForm_GeometricFigures
{
    [Serializable]
    class Triangle : Figure
    {
        private Point B;
        private Point C;

        public void pointB(int x, int y)
        {
            B = new Point(x, y);
        }

        public void pointC(int x, int y)
        {
            C = new Point(x, y);
        }

        public Triangle(Color color, int width) : base(color, width)
        {
        }
        
        public override void Draw(Graphics paper)
        {
            Pen pen = new Pen(color, width);
            paper.DrawLine(pen, A, C);
            paper.DrawLine(pen, A, B);
            paper.DrawLine(pen, C, B);
        }
    }
}