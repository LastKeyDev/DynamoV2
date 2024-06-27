namespace Dynamo.Pages
{
    partial class JsonConverterController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConverter = new Button();
            dtExcel = new DataGridView();
            btnSaveJson = new Button();
            btnAddFile = new Button();
            txtJson = new TextBox();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dtExcel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConverter.Location = new Point(611, 452);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(103, 28);
            btnConverter.TabIndex = 12;
            btnConverter.Text = "Convert";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // dtExcel
            // 
            dtExcel.AllowUserToAddRows = false;
            dtExcel.AllowUserToDeleteRows = false;
            dtExcel.AllowUserToResizeColumns = false;
            dtExcel.AllowUserToResizeRows = false;
            dtExcel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtExcel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtExcel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtExcel.BackgroundColor = SystemColors.ControlLightLight;
            dtExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtExcel.Location = new Point(3, 35);
            dtExcel.Name = "dtExcel";
            dtExcel.RowHeadersVisible = false;
            dtExcel.Size = new Size(711, 414);
            dtExcel.TabIndex = 8;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveJson.Location = new Point(147, 452);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(103, 28);
            btnSaveJson.TabIndex = 11;
            btnSaveJson.Text = "Save File";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnAddFile
            // 
            btnAddFile.Location = new Point(3, 4);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(103, 25);
            btnAddFile.TabIndex = 10;
            btnAddFile.Text = "Add File";
            btnAddFile.UseVisualStyleBackColor = true;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // txtJson
            // 
            txtJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtJson.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtJson.Location = new Point(3, 35);
            txtJson.Multiline = true;
            txtJson.Name = "txtJson";
            txtJson.Size = new Size(247, 414);
            txtJson.TabIndex = 9;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dtExcel);
            splitContainer1.Panel1.Controls.Add(btnConverter);
            splitContainer1.Panel1.Controls.Add(btnAddFile);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtJson);
            splitContainer1.Panel2.Controls.Add(btnSaveJson);
            splitContainer1.Size = new Size(974, 483);
            splitContainer1.SplitterDistance = 717;
            splitContainer1.TabIndex = 13;
            // 
            // JsonConverterController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 507);
            Controls.Add(splitContainer1);
            Name = "JsonConverterController";
            Text = "JsonConverterController";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dtExcel).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnConverter;
        private DataGridView dtExcel;
        private Button btnSaveJson;
        private Button btnAddFile;
        private TextBox txtJson;
        private SplitContainer splitContainer1;
    }
}