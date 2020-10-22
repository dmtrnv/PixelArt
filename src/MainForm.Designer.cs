namespace PixelArt
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.loadButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.pixelSizeComboBox = new System.Windows.Forms.ComboBox();
			this.colorTypeComboBox = new System.Windows.Forms.ComboBox();
			this.pixelSizeLabel = new System.Windows.Forms.Label();
			this.colorTypeLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(1024, 576);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(1042, 12);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 1;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButtonClickAsync);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(1042, 565);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Hide();
			this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
			// 
			// pixelSizeComboBox
			// 
			this.pixelSizeComboBox.DataSource = Model.PixelSize;
			this.pixelSizeComboBox.FormattingEnabled = true;
			this.pixelSizeComboBox.Location = new System.Drawing.Point(1042, 256);
			this.pixelSizeComboBox.Name = "pixelSizeComboBox";
			this.pixelSizeComboBox.Size = new System.Drawing.Size(75, 23);
			this.pixelSizeComboBox.TabIndex = 3;
			this.pixelSizeComboBox.Hide();
			this.pixelSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.pixelSizeComboBoxSelectedIndexChanged);
			// 
			// colorTypeComboBox
			// 
			this.colorTypeComboBox.DataSource = Model.ColorType;
			this.colorTypeComboBox.FormattingEnabled = true;
			this.colorTypeComboBox.Location = new System.Drawing.Point(1042, 321);
			this.colorTypeComboBox.Name = "colorTypeComboBox";
			this.colorTypeComboBox.Size = new System.Drawing.Size(75, 23);
			this.colorTypeComboBox.TabIndex = 4;
			this.colorTypeComboBox.Hide();
			this.colorTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.colorTypeComboBoxSelectedIndexChanged);
			// 
			// pixelSizeLabel
			// 
			this.pixelSizeLabel.AutoSize = true;
			this.pixelSizeLabel.Location = new System.Drawing.Point(1042, 238);
			this.pixelSizeLabel.Name = "pixelSizeLabel";
			this.pixelSizeLabel.Size = new System.Drawing.Size(54, 15);
			this.pixelSizeLabel.TabIndex = 5;
			this.pixelSizeLabel.Text = "Pixel size";
			this.pixelSizeLabel.Hide();
			// 
			// colorTypeLabel
			// 
			this.colorTypeLabel.AutoSize = true;
			this.colorTypeLabel.Location = new System.Drawing.Point(1042, 303);
			this.colorTypeLabel.Name = "colorTypeLabel";
			this.colorTypeLabel.Size = new System.Drawing.Size(62, 15);
			this.colorTypeLabel.TabIndex = 6;
			this.colorTypeLabel.Text = "Color type";
			this.colorTypeLabel.Hide();
			// 
			// MyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1129, 600);
			this.Controls.Add(this.colorTypeLabel);
			this.Controls.Add(this.pixelSizeLabel);
			this.Controls.Add(this.colorTypeComboBox);
			this.Controls.Add(this.pixelSizeComboBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.pictureBox);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PixelArt";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ComboBox pixelSizeComboBox;
		private System.Windows.Forms.ComboBox colorTypeComboBox;
		private System.Windows.Forms.Label pixelSizeLabel;
		private System.Windows.Forms.Label colorTypeLabel;
	}
}

