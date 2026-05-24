using System;
using System.Drawing;

namespace ShapeLibrary.Models
{
    public class Triangle : Shape
    {
        public double BaseLength { get; }
        public double Height { get; }

        public Triangle(int x, int y, Color color, double baseLength, double height)
            : base(x, y, color)
        {
            if (baseLength <= 0)
                throw new ArgumentException("Base must be positive");

            if (height <= 0)
                throw new ArgumentException("Height must be positive");

            BaseLength = baseLength;
            Height = height;
        }

        public override double FindArea()
        {
            return BaseLength * Height / 2;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            PointF[] points =
            {
                new PointF(PosX, PosY),
                new PointF(PosX + (float)BaseLength, PosY),
                new PointF(PosX + (float)(BaseLength / 2), PosY - (float)Height)
            };

            using (Brush brush = new SolidBrush(Color))
            {
                g.FillPolygon(brush, points);
            }
        }

        public override bool ContainsPoint(Point p)
        {
            PointF a = new PointF(PosX, PosY);
            PointF b = new PointF(PosX + (float)BaseLength, PosY);
            PointF c = new PointF(PosX + (float)(BaseLength / 2), PosY - (float)Height);

            float area = TriangleArea(a, b, c);
            float area1 = TriangleArea(p, b, c);
            float area2 = TriangleArea(a, p, c);
            float area3 = TriangleArea(a, b, p);

            return Math.Abs(area - (area1 + area2 + area3)) < 0.1f;
        }

        private float TriangleArea(PointF a, PointF b, PointF c)
        {
            return Math.Abs(
                (a.X * (b.Y - c.Y) +
                 b.X * (c.Y - a.Y) +
                 c.X * (a.Y - b.Y)) / 2f
            );
        }
    }
}