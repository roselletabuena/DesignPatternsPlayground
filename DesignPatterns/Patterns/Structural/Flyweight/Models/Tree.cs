﻿
using DesignPatterns.Patterns.Structural.Flyweight.Flyweights;

namespace DesignPatterns.Patterns.Structural.Flyweight.Models
{
    internal class Tree
    {
        private readonly int _x;
        private readonly int _y;
        private readonly TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public void Draw()
        {
            _type.Draw(_x, _y);
        }
    }
}
