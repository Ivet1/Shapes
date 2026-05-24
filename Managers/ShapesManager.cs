using System;
using System.Collections.Generic;
using ShapeLibrary.Models;

namespace ShapeLibrary.Managers
{
    public class ShapeManager
    {
        private readonly List<Shape> shapes = new();

        public IReadOnlyList<Shape> Shapes => shapes;

        public void Add(Shape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));

            shapes.Add(shape);
        }

        public void Remove(Shape shape)
        {
            if (shape == null)
                return;

            shapes.Remove(shape);
        }

        public void Insert(int index, Shape shape)
        {
            if (shape == null)
                return;

            if (index >= 0 && index <= shapes.Count)
                shapes.Insert(index, shape);
            else
                shapes.Add(shape);
        }

        public int IndexOf(Shape shape)
        {
            return shapes.IndexOf(shape);
        }
    }
}