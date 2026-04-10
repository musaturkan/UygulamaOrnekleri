using Microsoft.Extensions.DependencyInjection;

namespace Lokanta
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Masa_Click(object sender, EventArgs e)
        {
           // MasaSiparis masaSiparis = new MasaSiparis();
            MasaSiparis masaSiparis=Program.serviceProvider.GetService<MasaSiparis>();
            masaSiparis.ShowDialog();
        }
    }
}
