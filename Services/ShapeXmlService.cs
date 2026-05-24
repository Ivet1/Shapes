using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using ShapeLibrary.Models;

namespace ShapeLibrary.Services
{
    public class ShapeXmlService
    {
        public void Save(string filePath, List<Shape> shapes)
        {
            if (shapes == null || string.IsNullOrEmpty(filePath))
                return;
            var xml = new XElement("Shapes",
                shapes.Select(s =>
                {
                    if (s is Circle c)
                    {
                        return new XElement("Circle",
                            new XAttribute("x", c.PosX),
                            new XAttribute("y", c.PosY),
                            new XAttribute("radius", c.Radius),
                            new XAttribute("color", c.Color.Name)
                        );
                    }

                    if (s is RectangleShape r)
                    {
                        return new XElement("Rectangle",
                            new XAttribute("x", r.PosX),
                            new XAttribute("y", r.PosY),
                            new XAttribute("width", r.Width),
                            new XAttribute("height", r.Height),
                            new XAttribute("color", r.Color.Name)
                        );
                    }

                    if (s is Triangle t)
                    {
                        return new XElement("Triangle",
                            new XAttribute("x", t.PosX),
                            new XAttribute("y", t.PosY),
                            new XAttribute("base", t.BaseLength),
                            new XAttribute("height", t.Height),
                            new XAttribute("color", t.Color.Name)
                        );
                    }

                    return null;
                }).Where(e => e != null)
            );

            xml.Save(filePath);
        }

        public List<Shape> Load(string filePath)
        {
            var result = new List<Shape>();

            if (!File.Exists(filePath))
                return result;

            var doc = XElement.Load(filePath);

            foreach (var el in doc.Elements())
            {
                var xAttr = el.Attribute("x");
                var yAttr = el.Attribute("y");
                var colorAttr = el.Attribute("color");

                if (xAttr == null || yAttr == null || colorAttr == null)
                    continue;

                int x = (int)xAttr;
                int y = (int)yAttr;
                Color color = Color.FromName((string)colorAttr);

                string type = el.Name.LocalName;

                if (type == "Circle")
                {
                    var rAttr = el.Attribute("radius");
                    if (rAttr == null) continue;

                    double r = (double)rAttr;
                    result.Add(new Circle(x, y, color, r));
                }
                else if (type == "Rectangle")
                {
                    var wAttr = el.Attribute("width");
                    var hAttr = el.Attribute("height");

                    if (wAttr == null || hAttr == null) continue;

                    double w = (double)wAttr;
                    double h = (double)hAttr;
                    result.Add(new RectangleShape(x, y, color, w, h));
                }
                else if (type == "Triangle")
                {
                    var bAttr = el.Attribute("base");
                    var hAttr = el.Attribute("height");

                    if (bAttr == null || hAttr == null) continue;

                    double b = (double)bAttr;
                    double h = (double)hAttr;
                    result.Add(new Triangle(x, y, color, b, h));
                }
            }

            return result;
        }
    }
}