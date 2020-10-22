using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace PixelArt
{
	internal class Model
	{
        public Bitmap CurrentImage { get; set; } 
		public Dictionary<int, PixelizedImage> Images { get; set; } = new Dictionary<int, PixelizedImage>();
		public static readonly int[] PixelSize = new int[] { 1, 2, 4, 8, 16, 32 };
        public static readonly string[] ColorType = new string[] { "Original", "Grayscale" };
        private object @lock = new object();

		public Model()
		{		
		}

		public void GenerateImages()
		{
            if(Images.Count != 0)
			{
                foreach(var key in Images.Keys)
				{
                    Images[key].Dispose();
				}
			}

            Parallel.ForEach(PixelSize, size =>
			    {
				    var originalColor = Pixelize(size);
				    var grayscale = ChangeColorToGrayscale(originalColor);

				    if (Images.ContainsKey(size))
				    {
					    Images[size] = new PixelizedImage(originalColor, grayscale);
				    }
				    else
				    {
					    Images.Add(size, new PixelizedImage(originalColor, grayscale));
				    }
			    });
		}

		private Bitmap Pixelize(int pixelSize)
		{
            var amountOfPixels = pixelSize * pixelSize;
            int r, g, b;
            Color averageColor;
            Color currentPixelColor;
            Bitmap pixelizedImage;

            lock (@lock)
            { 
                pixelizedImage = new Bitmap(CurrentImage);
            }      
            
            for (var i = 0; i < pixelizedImage.Width; i += pixelSize)
            {
                for (var j = 0; j < pixelizedImage.Height; j += pixelSize)
                {
                    r = 0;
                    g = 0;
                    b = 0;
                        
                    for (var k = i; k < i + pixelSize; k++)
                    {
                        for (var z = j; z < j + pixelSize; z++)
                        {
                            currentPixelColor = pixelizedImage.GetPixel(k, z);
                            r += currentPixelColor.R;
                            g += currentPixelColor.G;
                            b += currentPixelColor.B;
                        }
                    }
                    
                    averageColor = Color.FromArgb(r / amountOfPixels, g / amountOfPixels, b / amountOfPixels);

                    for (var k = i; k < i + pixelSize; k++)
                    {
                        for (var z = j; z < j + pixelSize; z++)
                        {
                            pixelizedImage.SetPixel(k, z, averageColor);
                        }
                    }
                }
            }

            return pixelizedImage; 
	    }

		private Bitmap ChangeColorToGrayscale(Bitmap original)
		{
            Color originalPixel;
            int grayscaleValue;
            Bitmap grayscale;
            
            lock (@lock)
			{
                grayscale = new Bitmap(original);
			}
           
            for (var i = 0; i < grayscale.Width; i++)
			{
                for (var j = 0; j < grayscale.Height; j++)
				{
                    originalPixel = grayscale.GetPixel(i, j);
                    grayscaleValue = (int)((0.2627 * originalPixel.R) + (0.6780 * originalPixel.G) + (0.0593* originalPixel.B));
                    grayscale.SetPixel(i, j, Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue));
				}
			}

            return grayscale; 
		}
	}
}
