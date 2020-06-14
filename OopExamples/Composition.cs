using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.ShapeClass
{
    public class Composition1 : ICircle, IRectangles
    {
        public Circle Circle { get; set; }

        public List<Rectangle> Rectangles { get; set; }

        public Rectangle TopRectangle { get; set; }

        public Rectangle BottomRectangle { get; set; }
    }

    public class Composition2 : ICircle, IRectangles
    {
        public Circle Circle { get; set; }
       
        public List<Rectangle> Rectangles { get; set; }
    }

    public interface ICircle
    {
        Circle Circle { get; set; }
    }

    public interface IRectangles
    {
        List<Rectangle> Rectangles { get; set; }
    }

    public static class CompositionExample
    {
        public static void Run()
        {
            //var compositions = new List<ICircle>();
            var compositions = new List<IRectangles>();

            compositions.Add(new Composition1()
            {
                Circle = new Circle(10),
                Rectangles = new List<Rectangle>() { new Rectangle(5, 8), new Square(15) },
                TopRectangle = new Rectangle(10,10),
                BottomRectangle = new Square(10)
            });

            compositions.Add(new Composition2()
            {
                Circle = new Circle(20),
                Rectangles = new List<Rectangle>() { new Rectangle(10,20), new Rectangle(20,25)}
            });

            foreach (var composition in compositions)
            {
                //composition.Circle.Draw();
                foreach (Rectangle rectangle in composition.Rectangles)
                {
                    rectangle.Draw();
                }


            }
        }
    }
}
