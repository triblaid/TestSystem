namespace TestSystem
{
    partial class FormCalculation
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
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.textBoxCalculation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Location = new System.Drawing.Point(481, 40);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(75, 30);
            this.buttonCalculation.TabIndex = 0;
            this.buttonCalculation.Text = "Посчитать";
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCalculation.Location = new System.Drawing.Point(12, 41);
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.Size = new System.Drawing.Size(463, 29);
            this.textBoxCalculation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Значение из ячейки таблицы можно получить используя (строка, столбец). Пример: (1" +
    ",1)";
            // 
            // FormCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 82);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCalculation);
            this.Controls.Add(this.buttonCalculation);
            this.Name = "FormCalculation";
            this.Text = "FormCalculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.TextBox textBoxCalculation;
        private System.Windows.Forms.Label label1;
    }
}