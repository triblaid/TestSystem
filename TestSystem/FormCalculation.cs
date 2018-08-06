using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class FormCalculation : Form
    {
    public FormCalculation()
        {
            InitializeComponent();
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                PostfixNotationExpression postfix = new PostfixNotationExpression();
                main.dataGridView1.CurrentCell.Value = postfix.result(textBoxCalculation.Text.ToString(), main.dataGridView1).ToString();
                this.Close();
            }
        }
    }
}
