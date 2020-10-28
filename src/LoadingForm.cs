using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
    internal partial class LoadingForm : Form
    {
        private readonly Action process;

        public LoadingForm(Action process)
        {
            InitializeComponent();

            if (process == null)
            {
                throw new ArgumentNullException();
            }

            this.process = process;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await Task.Run(process).ContinueWith(t => this.Close(), TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
