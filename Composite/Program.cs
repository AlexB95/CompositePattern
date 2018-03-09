using Composite.BL;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 
            CompositeElemnt root = new CompositeElement("Video");
            root.Add(new PrimitiveElement("Duration"));
            
            CompositeElement fps = new Compositeelement("Frames Per Second");
            root.Add(fps);
            
            CompositeElement photo = new CompositeElement("Photo");
            fps.Add(photo);
            
            CompositeElement picture = new CompositeElement("Picture");
            picture.Add(new PrimitiveElement("Color Blue"));
            picture.Add(new PrimitiveElement("Color Red"));
            picture.Add(new PrimitiveElement("Color Yellow"));
            photo.Add(picture);
            
            CompositeElement line = new CompositeElement("Line");
            picture.Add(new PrimitiveElement("Color Blue"));
            picture.Add(new PrimitiveElement("Color Red"));
            picture.Add(new PrimitiveElement("Color Yellow"));
            picture.Add(line);
            
            CompositeElement circle = new CompositeElement("Circle");
            picture.Add(new PrimitiveElement("Color Blue"));
            picture.Add(new PrimitiveElement("Color Red"));
            picture.Add(new PrimitiveElement("Color Yellow"));
            picture.Add(circle);
            
            CompositeElement square = new CompositeElement("square");
            picture.Add(new PrimitiveElement("Color Blue"));
            picture.Add(new PrimitiveElement("Color Red"));
            picture.Add(new PrimitiveElement("Color Yellow"));
            picture.Add(square);
            
            // Create a branch

            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);
            
            // Add and remove a PrimitiveElement

            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            pe.Add(new CompositeElement("Blue Point"));
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
