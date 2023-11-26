// See https://aka.ms/new-console-template for more information
using Elements;
using Universe;


IElementImplementation implementation = new DefaultElementImplementation();
Carbon e1 = new(implementation);
Hydrogen e2 = new(implementation);
Lithium e3 = new(implementation);

e1.DisplayInfo();
e2.DisplayInfo();
e3.DisplayInfo();

Console.WriteLine("\n-----------------------------------------------------------\n");

IUniverseImplementation Iuniv = new DefaultUniverseImplementation();
TwoDimensionalUniverse univ = new(Iuniv,50,50);
univ.AddElement(e1, 0, 0);
univ.AddElement(e2, 1, 1);
univ.AddElement(e3, 2, 2);

List<Element> elements = univ.GetElement();
univ.DisplayInfo();

Console.ReadKey();




