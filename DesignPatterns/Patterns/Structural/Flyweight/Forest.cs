
using DesignPatterns.Patterns.Structural.Flyweight.Factories;
using DesignPatterns.Patterns.Structural.Flyweight.Models;

namespace DesignPatterns.Patterns.Structural.Flyweight
{
    internal class Forest
    {
        private readonly List<Tree> _trees = new();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, type);
            _trees.Add(tree);  
        }

        public void Draw()
        {
            Console.WriteLine("\nRendering forest with " + _trees.Count + " trees:");
            foreach (var tree in _trees)
            {
                tree.Draw();
            }
        }
    }
}
