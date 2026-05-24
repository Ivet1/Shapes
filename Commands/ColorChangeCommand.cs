using ShapeLibrary.Models.Contracts;   
using ShapeLibrary.Models;
using System.Drawing;

namespace ShapeLibrary.Commands
{
    public class ColorChangeCommand : ICommand
    {
        private readonly Shape shape;
        private readonly Color oldColor;
        private readonly Color newColor;

        public ColorChangeCommand(Shape shape, Color oldColor, Color newColor)
        {
            this.shape = shape;
            this.oldColor = oldColor;
            this.newColor = newColor;
        }

        public void Execute()
        {
            shape.Color = newColor;
        }

        public void Undo()
        {
            shape.Color = oldColor;
        }
    }
}