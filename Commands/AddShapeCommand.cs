using ShapeLibrary.Models.Contracts;
using ShapeLibrary.Models;
using System.Drawing;

namespace ShapeLibrary.Commands
{
    public class AddShapeCommand : ICommand
    {
        private readonly List<Shape> shapes;
        private readonly Shape shape;

        public AddShapeCommand(List<Shape> shapes, Shape shape)
        {
            this.shapes = shapes;
            this.shape = shape;
        }

        public void Execute()
        {
            shapes.Add(shape);
        }

        public void Undo()
        {
            shapes.Remove(shape);
        }
    }
}