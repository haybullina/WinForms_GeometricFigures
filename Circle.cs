using System;
using System.Drawing;

namespace WinForm_GeometricFigures
{
    [Serializable]
    class Circle : Figure
    {
        private int radius;

        public Circle(Color color, int width, int radius) : base(color, width)
        {
            this.radius = radius;
        }
        
        public override void Draw(Graphics paper)
        {
            paper.DrawEllipse(new Pen(color, width), A.X-radius, A.Y-radius, radius*2, radius*2);
        }
    }
}