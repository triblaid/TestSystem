using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public class ReadCSV
    {
        public static List<TableMain> Read(OpenFileDialog ofd)
        {
            using (StreamReader sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open)))
            { 
                CsvReader csv = new CsvReader(sr);
                csv.Configuration.HasHeaderRecord = true;
                return csv.GetRecords<TableMain>().ToList();
            }
        }
    }
}
