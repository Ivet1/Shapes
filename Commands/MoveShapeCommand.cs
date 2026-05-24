using ShapeLibrary.Models;
using ShapeLibrary.Models.Contracts;

namespace ShapeLibrary.Commands
{
    public class MoveShapeCommand : ICommand
    {
        private readonly Shape shape;
        private readonly int oldX, oldY;
        private readonly int newX, newY;

        public MoveShapeCommand(Shape shape, int oldX, int oldY, int newX, int newY)
        {
            this.shape = shape;

            this.oldX = oldX;
            this.oldY = oldY;

            this.newX = newX;
            this.newY = newY;
        }

        public void Execute()
        {
            shape.Move(newX, newY);
        }

        public void Undo()
        {
            shape.Move(oldX, oldY);
        }
    }
}