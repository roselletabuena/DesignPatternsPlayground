using DesignPatterns.Patterns.Behavioral.Strategy.Context;
using DesignPatterns.Patterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Patterns.Behavioral.Strategy
{
    internal class Demo
    {
        public static void Run()
        {
            var compressor = new ImageCompressor();
            compressor.SetCompressionStrategy(new JpegCompression());
            compressor.CompressImage("HolidayPhoto.png");

            compressor.SetCompressionStrategy(new PngCompression());
            compressor.CompressImage("ProfilePicture.jpg");

            compressor.SetCompressionStrategy(new WebpCompression());
            compressor.CompressImage("Landscape.png");

        }
    }
}
