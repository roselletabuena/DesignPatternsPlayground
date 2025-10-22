

using DesignPatterns.Patterns.Structural.Flyweight.Flyweights;

namespace DesignPatterns.Patterns.Structural.Flyweight.Factories
{
    internal class TreeFactory
    {

        private static readonly Dictionary<string, TreeType> _treeTypes = new();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            string key = $"{name}_{color}_{texture}";

            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
            }

            return _treeTypes[key];
        }

        public static int GetCachedTypesCount() => _treeTypes.Count;
     }
}
