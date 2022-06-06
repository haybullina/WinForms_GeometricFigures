using System;
using System.Drawing;

namespace WinForm_GeometricFigures
{
    [Serializable]
    class LineSegment : Figure
    {
        private Point B;

        public void pointB(int x, int y)
        {
            B = new Point(x, y);
        }

        public LineSegment(Color color, int width) : base(color, width)
        {
        }

        public override void Draw(Graphics paper)
        {
            Pen pen = new Pen(color, width);
            paper.DrawLine(pen, A, B);
        }
    }
}