
using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.ConcreteFactories;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.AbstractFactory
{
    internal sealed class ThemeFactoryProvider
    {
        private static readonly Lazy<ThemeFactoryProvider> _instance = new Lazy<ThemeFactoryProvider>(() => new ThemeFactoryProvider());
        public static ThemeFactoryProvider Instance => _instance.Value;

        private IUIFactory _currentFactory;

        private ThemeFactoryProvider() { }

        public IUIFactory GetFactory(string theme)
        {
            if (_currentFactory != null)
            {
                return _currentFactory;
            }

            _currentFactory = theme.ToLower() switch
            {
                "light" => new LightThemeFactory(),
                "dark" => new DarkThemeFactory(),
                _ => throw new ArgumentException($"Theme '{theme}' not supported.")
            };

            return _currentFactory;
        }
    }

  

}
