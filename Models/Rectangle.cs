using System;
using System.Drawing; 
namespace ShapeLibrary.Models
{
    public class RectangleShape : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public RectangleShape(int x, int y, Color color, double width, double height)
            : base(x, y, color)
        {
            if (width <= 0)
                throw new ArgumentException("Width must be positive");

            if (height <= 0)
                throw new ArgumentException("Height must be positive");

            Width = width;
            Height = height;
        }

        public override double FindArea()
        {
            return Width * Height;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, PosX, PosY, (float)Width, (float)Height);
            }
        }

        public override bool ContainsPoint(Point p)
        {
            return p.X >= PosX &&
                   p.X <= PosX + Width &&
                   p.Y >= PosY &&
                   p.Y <= PosY + Height;
        }
    }
}