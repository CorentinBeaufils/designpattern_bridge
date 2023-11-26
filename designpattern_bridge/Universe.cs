using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elements;

namespace Universe
{
    public interface IUniverseImplementation
    {
        void AddElement(Element element, int x, int y);
        List<Element> GetElement();
        Element GetElementAtPos(int x, int y);
    }

        public class DefaultUniverseImplementation : IUniverseImplementation
        {
            protected List<Element> elements = new List<Element>();
            public void AddElement(Element element, int x, int y)
            {
                element.PositionX = x;
                element.PositionY = y;
                elements.Add(element);
            }

            public List<Element> GetElement()
            {
                return elements;
            }

            public Element GetElementAtPos(int x, int y)
            {
                return elements.Find(e => e.PositionX == x && e.PositionY == y);
            }

            public Element GetElementAtPosition(int x, int y)
            {
                throw new NotImplementedException();
            }

            public List<Element> GetElements()
            {
                throw new NotImplementedException();
            }
        }

    public class Universe
    {
        protected IUniverseImplementation universeImplementation;

        public Universe(IUniverseImplementation implementation)
        {
            universeImplementation = implementation;
        }

        public void AddElement(Element element, int x, int y)
        {
            universeImplementation.AddElement(element, x, y);
        }

        public List<Element> GetElement()
        {
            return universeImplementation.GetElement();
        }

        public Element GetElementAtPosition(int x, int y)
        {
            return universeImplementation.GetElementAtPos(x, y);
        }
    }

    public class TwoDimensionalUniverse : Universe
    {
        private int Height;
        private int Width;
        public TwoDimensionalUniverse(IUniverseImplementation implementation,int height,int width) : base(implementation)
        {
            Height = height;
            Width = width;
        }
        public void DisplayInfo()
        {
            foreach (var Elem in this.GetElement())
            {
                Elem.DisplayInfo();
                Console.WriteLine($"au Postion (x,y) : ({Elem.PositionX},{Elem.PositionY})\n");
            }
        }
    }
}
