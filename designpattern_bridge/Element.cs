using System;


namespace Elements
{
    public interface IElementImplementation
    {
        void DisplayInfo(Element element);
    }

    public class DefaultElementImplementation : IElementImplementation
    {
        public void DisplayInfo(Element element)
        {
            Console.WriteLine($"Name: {element.Name}, Symbol: {element.Symbol}, Mass : {element.Mass}");
        }
    }
    public class Element
    {
        public string Name {  get; set; }
        public string Symbol { get; set; }
        public double Mass { get; set; }

        public int PositionX { get; set; } = 0;
        public int PositionY { get; set; } = 0;

        protected IElementImplementation elementImplementation;

        public Element(IElementImplementation implementation) 
        {
            elementImplementation = implementation;
        }
        
        public void DisplayInfo()
        {
            elementImplementation.DisplayInfo(this);
        }
    }

    public class Carbon : Element
    {
        public Carbon(IElementImplementation implementation) : base(implementation)
        {
            Name = "Carbon";
            Symbol = "C";
            Mass = 12.01074;
        }
    }

    public class Hydrogen : Element
    {
        public Hydrogen(IElementImplementation implementation) : base(implementation)
        {
            Name = "Hydrogen";
            Symbol = "H";
            Mass = 1.00794;
        }
    }

    public class Lithium : Element
    {
        public Lithium(IElementImplementation implementation) : base(implementation)
        {
            Name = "Lithium";
            Symbol = "Li";
            Mass = 6.941;
        }
    }
}
