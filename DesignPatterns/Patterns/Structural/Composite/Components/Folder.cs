using DesignPatterns.Patterns.Structural.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Composite.Components
{
    internal class Folder : IFileSystemItem
    {
        public string Name { get; }
        private readonly List<IFileSystemItem> _children = new();

        public Folder(string name)
        {
            Name = name;
        }

        public void Add(IFileSystemItem item) => _children.Add(item);
        public void Remove(IFileSystemItem item) => _children.Remove(item);

        public long GetSize()
        {
            long totalSize = 0;
            foreach (var item in  _children)
            {
                totalSize += item.GetSize();
            }

            return totalSize;
        }

        public void Display(string indent="")
        {
            Console.WriteLine($"{indent} + {Name} / ({GetSize()}) KB");
            foreach (var item in _children)
            {
                item.Display(indent + " ");
            }
        }

    }
}
