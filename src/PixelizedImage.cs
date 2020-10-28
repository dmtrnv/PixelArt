using System;
using System.Drawing;

namespace PixelArt
{
    internal class PixelizedImage : IDisposable
    {
        public Bitmap OriginalColor { get; set; }
        public Bitmap Grayscale { get; set; }

        public PixelizedImage(Bitmap originalColor, Bitmap grayscale)
        {
            this.OriginalColor = originalColor;
            this. Grayscale = grayscale;
        }

        public void Dispose()
        {
            OriginalColor.Dispose();
            Grayscale.Dispose();
        }
    }
}
