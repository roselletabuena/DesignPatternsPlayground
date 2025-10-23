using DesignPatterns.Patterns.Structural.Proxy.Interfaces;


namespace DesignPatterns.Patterns.Structural.Proxy.Models
{
    /// <summary>
    /// The RealSubject that performs the actual work of displaying the document.
    /// </summary>
    internal class ProxyDocument : IDocument
    {
        private RealDocument? _realDocument;
        private readonly string _fileName;
        private readonly string _userRole;

        public ProxyDocument(string fileName, string userRole)
        {
            _fileName = fileName;
            _userRole = userRole;
        }

        public void Display()
        {
            if (HasAccess())
            {
                if (_realDocument == null)
                {
                    _realDocument = new RealDocument(_fileName);
                }
                else
                {
                    Console.WriteLine($"[ProxyDocument] Access denied for user with role '{_userRole}'.");
                }
            }
        }

        public bool HasAccess()
        {
            return _userRole == "Admin" || _userRole == "Manager";
        }
    }
}
