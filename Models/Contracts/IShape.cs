using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary.Models.Contracts
{
  public interface IShape
    {
        void Draw(Graphics graphics, Pen pen);
        double FindArea();
        void Move(int x, int y);
    }
}
