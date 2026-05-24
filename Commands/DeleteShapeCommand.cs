using ShapeLibrary.Models.Contracts;
using ShapeLibrary.Models;
using System.Collections.Generic;

namespace ShapeLibrary.Commands
{
    public class DeleteShapeCommand : ICommand
    {
        private readonly List<Shape> shapes;
        private readonly Shape shape;
        private int index;

        public DeleteShapeCommand(List<Shape> shapes, Shape shape)
        {
            this.shapes = shapes;
            this.shape = shape;
        }

        public void Execute()
        {
            index = shapes.IndexOf(shape);

            if (index >= 0)
            {
                shapes.RemoveAt(index);
            }
        }

        public void Undo()
        {
            if (index >= 0 && index <= shapes.Count)
            {
                shapes.Insert(index, shape);
            }
            else
            {
                shapes.Add(shape);
            }
        }
    }
}