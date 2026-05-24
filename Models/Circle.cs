using System;
using System.Drawing;

namespace ShapeLibrary.Models
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(int x, int y, Color color, double radius)
            : base(x, y, color)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive!");

            Radius = radius;
        }

        public override double FindArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                float size = (float)(Radius * 2);

                g.FillEllipse(brush,
                    PosX,
                    PosY,
                    size,
                    size);
            }
        }

        public override bool ContainsPoint(Point p)
        {
            double centerX = PosX + Radius;
            double centerY = PosY + Radius;

            double dx = p.X - centerX;
            double dy = p.Y - centerY;

            return dx * dx + dy * dy <= Radius * Radius;
        }
    }
}