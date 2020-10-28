using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
	internal partial class MainForm : Form
	{
		private readonly Model model = new Model();

		public MainForm()
		{
			InitializeComponent();
		}

		private async void LoadButtonClickAsync(object sender, EventArgs e)
		{
			using (var fileDialog = new OpenFileDialog())
			{ 
				fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
				fileDialog.Title = "Select an image";

				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					model.CurrentImage = new Bitmap(Image.FromFile(fileDialog.FileName), pictureBox.Width, pictureBox.Height);					
					await Task.Run(() =>
						{
							using(var process = new LoadingForm(model.GenerateImages))
							{
								process.ShowDialog();
							}
						});
					
					pictureBox.Image = model.CurrentImage;
					pixelSizeComboBox.SelectedItem = 1;
					colorTypeComboBox.SelectedItem = "Original";

					pixelSizeLabel.Show();
					colorTypeLabel.Show();
					pixelSizeComboBox.Show();
					colorTypeComboBox.Show();
					saveButton.Show();	
				}
			}
		}
		
		private void SaveButtonClick(object sender, EventArgs e)
		{
			using (var saveDialog = new SaveFileDialog())
			{ 
				saveDialog.Filter = "Jpg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|Tiff Image|*.tiff";
				saveDialog.Title = "Save current image";
				saveDialog.ShowDialog();
				
				if (saveDialog.FileName != string.Empty)
				{
					using (var fs = (FileStream)saveDialog.OpenFile())
					{
						switch (saveDialog.FilterIndex)
						{
							case 1:
								pictureBox.Image.Save(fs, ImageFormat.Jpeg);
								break;
							case 2:
								pictureBox.Image.Save(fs, ImageFormat.Png);
								break;
							case 3:
								pictureBox.Image.Save(fs, ImageFormat.Bmp);
								break;
							case 4:
								pictureBox.Image.Save(fs, ImageFormat.Gif);
								break;
							case 5:
								pictureBox.Image.Save(fs, ImageFormat.Tiff);
								break;
						}
					}
				}
			}				
		}

		private void PixelSizeComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			CheckImageState();
		}
		
		private void ColorTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			CheckImageState();
		}

		private void CheckImageState()
		{
			if ((string)colorTypeComboBox.SelectedItem == "Grayscale")
			{
				pictureBox.Image = model.Images[(int)pixelSizeComboBox.SelectedItem].Grayscale;
			}
			else
			{
				pictureBox.Image = model.Images[(int)pixelSizeComboBox.SelectedItem].OriginalColor;
			}
		}
	}
}
