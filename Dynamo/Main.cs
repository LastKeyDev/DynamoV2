using System.Data;
using System.Windows;
using Dynamo.Pages;

namespace Dynamo
{
    public partial class Main : Form
    {
        private FormatConverter converter = new FormatConverter();
        JsonConverterController controller = new JsonConverterController();
        private DataTable dt = new DataTable();
        private int column;
        public Main()
        {
            InitializeComponent();
           


        }
        private void openFormater(object sender, EventArgs e)
        {
            controller.MdiParent = this;
            controller.Show();
        }

    }
}
