
namespace DesignPatterns.Patterns.Creational.Prototype.Prototypes
{
    internal class PrototypeRegistry
    {
        private readonly Dictionary<string, IDocumentPrototype> _prototypes = new();

        public void RegisterPrototype(string Key, IDocumentPrototype prototype)
        {
            _prototypes.Add(Key, prototype);
        }

        public IDocumentPrototype GetClone(string key, bool deep = false)
        {
            if (!_prototypes.ContainsKey(key))
                throw new ArgumentException($"Prototype with key '{key}' not found.");

            return deep ? _prototypes[key].DeepClone() : _prototypes[key].Clone();
        }
    }
}
