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
    public class WriteCSV
    {
        public static void Write(SaveFileDialog sfd, List<TableMain> list)
        {
            using (StreamWriter writer = new StreamWriter(sfd.FileName))
            {
                CsvWriter csvWriter = new CsvWriter(writer);
                csvWriter.Configuration.Delimiter = ",";
                csvWriter.Configuration.QuoteAllFields = true;
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.AutoMap<TableMain>();
                csvWriter.WriteHeader(typeof(TableMain));
                csvWriter.NextRecord();
                csvWriter.WriteRecords(list);
                writer.Flush();
            }
        }
    }
}
