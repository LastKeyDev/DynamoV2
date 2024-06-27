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

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtJson.Text))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Obtener la ruta del archivo seleccionado
                        string filePath = saveFileDialog.FileName;

                        // Generar el contenido del archivo
                        string fileContent = txtJson.Text;

                        // Escribir el contenido en el archivo
                        File.WriteAllText(filePath, fileContent);

                        Console.WriteLine("Archivo guardado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al guardar el archivo: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero se debe generar un JSON", "", MessageBoxButtons.OK);
            }
        }
    }
    
}
