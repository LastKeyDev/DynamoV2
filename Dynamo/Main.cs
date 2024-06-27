using System.Data;
using System.Windows;
using Dynamo.Pages;

namespace Dynamo
{
    public partial class Main : Form
    {
        private FormatConverter converter = new FormatConverter();
     
        private DataTable dt = new DataTable();
        private int column;
        public Main()
        {
            InitializeComponent();
  

        }
        private void openFormater(object sender, EventArgs e)
        {
            JsonConverterController controller = new JsonConverterController
            {
                MdiParent = Main.ActiveForm
            };
            controller.Show();
        }

    }
}
