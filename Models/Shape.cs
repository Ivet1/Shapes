using ShapeLibrary.Models.Contracts;
using System.Drawing;

namespace ShapeLibrary.Models
{
    public abstract class Shape : IShape
    {
        private int posX;
        private int posY;

        public int PosX
        {
            get { return posX; }
            private set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            private set { posY = value; }
        }

        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Shape(int x, int y, Color color)
        {
            posX = x;
            posY = y;
            this.color = color;
        }

        public void Move(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public abstract bool ContainsPoint(Point p);
        public abstract double FindArea();
        public abstract void Draw(Graphics graphics, Pen pen);
    }
}