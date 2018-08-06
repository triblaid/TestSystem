namespace TestSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReaderCSV = new System.Windows.Forms.Button();
            this.buttonWriterCSV = new System.Windows.Forms.Button();
            this.buttonSaveDataBase = new System.Windows.Forms.Button();
            this.buttonLoadDataBase = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // buttonReaderCSV
            // 
            this.buttonReaderCSV.Location = new System.Drawing.Point(12, 419);
            this.buttonReaderCSV.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonReaderCSV.Name = "buttonReaderCSV";
            this.buttonReaderCSV.Size = new System.Drawing.Size(120, 30);
            this.buttonReaderCSV.TabIndex = 1;
            this.buttonReaderCSV.Text = "Открыть .CSV";
            this.buttonReaderCSV.UseVisualStyleBackColor = true;
            this.buttonReaderCSV.Click += new System.EventHandler(this.buttonReaderCSV_Click);
            // 
            // buttonWriterCSV
            // 
            this.buttonWriterCSV.Enabled = false;
            this.buttonWriterCSV.Location = new System.Drawing.Point(145, 419);
            this.buttonWriterCSV.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.buttonWriterCSV.Name = "buttonWriterCSV";
            this.buttonWriterCSV.Size = new System.Drawing.Size(120, 30);
            this.buttonWriterCSV.TabIndex = 1;
            this.buttonWriterCSV.Text = "Сохранить .CSV";
            this.buttonWriterCSV.UseVisualStyleBackColor = true;
            this.buttonWriterCSV.Click += new System.EventHandler(this.buttonWriterCSV_Click);
            // 
            // buttonSaveDataBase
            // 
            this.buttonSaveDataBase.Enabled = false;
            this.buttonSaveDataBase.Location = new System.Drawing.Point(337, 419);
            this.buttonSaveDataBase.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonSaveDataBase.Name = "buttonSaveDataBase";
            this.buttonSaveDataBase.Size = new System.Drawing.Size(120, 30);
            this.buttonSaveDataBase.TabIndex = 1;
            this.buttonSaveDataBase.Text = "Сохранить в БД";
            this.buttonSaveDataBase.UseVisualStyleBackColor = true;
            this.buttonSaveDataBase.Click += new System.EventHandler(this.buttonSaveDataBase_Click);
            // 
            // buttonLoadDataBase
            // 
            this.buttonLoadDataBase.Location = new System.Drawing.Point(470, 419);
            this.buttonLoadDataBase.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonLoadDataBase.Name = "buttonLoadDataBase";
            this.buttonLoadDataBase.Size = new System.Drawing.Size(120, 30);
            this.buttonLoadDataBase.TabIndex = 1;
            this.buttonLoadDataBase.Text = "Загрузить БД";
            this.buttonLoadDataBase.UseVisualStyleBackColor = true;
            this.buttonLoadDataBase.Click += new System.EventHandler(this.buttonLoadDataBase_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Enabled = false;
            this.buttonExportExcel.Location = new System.Drawing.Point(652, 419);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(120, 30);
            this.buttonExportExcel.TabIndex = 1;
            this.buttonExportExcel.Text = "Экспорт в Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дополнительное расчетное поле выводится по двойному клику на ячейку";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.buttonLoadDataBase);
            this.Controls.Add(this.buttonSaveDataBase);
            this.Controls.Add(this.buttonWriterCSV);
            this.Controls.Add(this.buttonReaderCSV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReaderCSV;
        private System.Windows.Forms.Button buttonWriterCSV;
        private System.Windows.Forms.Button buttonSaveDataBase;
        private System.Windows.Forms.Button buttonLoadDataBase;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Label label1;
    }
}

