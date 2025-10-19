
using DesignPatterns.Patterns.Structural.Composite.Components;

namespace DesignPatterns.Patterns.Structural.Composite
{
    internal class Demo
    {
      
        public static void Run()
        {
            Console.WriteLine("=== Composite Pattern Demo ===\n");

            // Create individual files (leaves)
            var fileA = new FileItem("Resume.docx", 120);
            var fileB = new FileItem("Photo.png", 450);
            var fileC = new FileItem("Presentation.pptx", 1024);
            var fileD = new FileItem("Notes.txt", 80);


            // Create folders (composites)
            var documents = new Folder("Documents");
            var images = new Folder("Images");
            var root = new Folder("Root");

            documents.Add(fileA);
            documents.Add(fileC);
            images.Add(fileB);
            root.Add(documents);
            root.Add(images);
            root.Add(fileD);

            root.Display();

            Console.WriteLine("\nTotal storage used: " + root.GetSize() + " KB");
        }


        

    }
}
