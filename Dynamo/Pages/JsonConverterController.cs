using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using static System.Resources.ResXFileRef;

namespace Dynamo.Pages
{
    public partial class JsonConverterController : Form
    {
        private FormatConverter _converter = new FormatConverter();
        private DataTable _dt = new DataTable();
        public JsonConverterController()
        {
            InitializeComponent();

        }
        private DataGridView _dtExcel;

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            _dt = _converter.PopulateGrid();
            dtExcel.DataSource = _dt.DefaultView;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            txtJson.Text = _converter.JsonConverter(_dt, 3);
        }
    }
}
