using DesignPatterns.Patterns.Creational.Builder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder.Builders
{
    internal interface IReportBuilder
    {
        void SetTitle(string title);
        void SetHeader();
        void SetContent(string content);
        void SetFooter();
        Report GetReport();
    }
}
