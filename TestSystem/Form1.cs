using BotAgent.DataExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class Form1 : Form
    {
        private List<TableMain> listTM;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReaderCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*csv", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        listTM = ReadCSV.Read(ofd).ToList();
                        dataGridView1.DataSource = listTM;
                    }
                }
                buttonSaveDataBase.Enabled = true;
                buttonWriterCSV.Enabled = true;
                buttonExportExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWriterCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        WriteCSV.Write(sfd, listTM);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                //поменять путь до базы
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Сергей\source\repos\TestSystem\TestSystem\DatabaseMain.mdf;Integrated Security=True";
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    foreach (TableMain item in listTM)
                    {
                        WorkDataBase.SaveItem(item, sqlConnection);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                //Поменять путь до базы
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Сергей\source\repos\TestSystem\TestSystem\DatabaseMain.mdf;Integrated Security=True";
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    dataGridView1.DataSource = WorkDataBase.LoadItem(sqlConnection);
                }
                buttonSaveDataBase.Enabled = true;
                buttonWriterCSV.Enabled = true;
                buttonExportExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "XLSX|*.xlsx", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Excel xl = new Excel();
                        string[] header = new string[dataGridView1.ColumnCount];
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                            header[i] = dataGridView1.Columns[i].HeaderText;
                        xl.AddRow(header);
                        string[] row = new string[dataGridView1.ColumnCount];
                        for (int i = 0; i < listTM.Count; i++)
                        {
                            row[0] = listTM[i].id.ToString();
                            row[1] = listTM[i].indexid;
                            row[2] = listTM[i].year;
                            row[3] = listTM[i].month;
                            row[4] = listTM[i].day;
                            row[5] = listTM[i].hour;
                            row[6] = listTM[i].zsp;
                            row[7] = listTM[i].planvalueproductionges;
                            row[8] = listTM[i].planvalueproductionaes;
                            row[9] = listTM[i].planvalueproductiontes;
                            row[10] = listTM[i].sumtminges;
                            row[11] = listTM[i].sumtminaes;
                            row[12] = listTM[i].sumtmintes;
                            row[13] = listTM[i].sumtgminges;
                            row[14] = listTM[i].sumtgminaes;
                            row[15] = listTM[i].sumtgmintes;
                            row[16] = listTM[i].sumtmaxges;
                            row[17] = listTM[i].sumtmaxaes;
                            row[18] = listTM[i].sumtmaxtes;
                            row[19] = listTM[i].planvaluedemand;
                            row[20] = listTM[i].planvalueexport;
                            row[21] = listTM[i].planvalueimport;
                            row[22] = listTM[i].averpricebuy;
                            row[23] = listTM[i].averpricecell;
                            xl.AddRow(row);
                        }
                        xl.FileSave(sfd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCalculation form = new FormCalculation(); 
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
