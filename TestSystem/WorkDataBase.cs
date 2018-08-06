using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestSystem
{
    public class WorkDataBase
    {

        public static DataTable LoadItem(SqlConnection sqlConnection)
        {
            string sql = "SELECT * FROM TableMain";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

            public static void SaveItem(TableMain item, SqlConnection sqlConnection)
        {
            DatabaseMainEntities db = new DatabaseMainEntities();
            SqlCommand sqlCommand;
            if (db.TableMain.Where(x => x.id == item.id).ToList().Count == 0)
            {
                // 30 секунд
                sqlCommand = new SqlCommand("INSERT INTO [TableMain] " +
            "(id,indexid,year,month,day,hour,zsp,planvalueproductionges,planvalueproductionaes,planvalueproductiontes,sumtminges,sumtminaes,sumtmintes,sumtgminges,sumtgminaes,sumtgmintes,sumtmaxges,sumtmaxaes,sumtmaxtes,planvaluedemand,planvalueexport,planvalueimport,averpricebuy,averpricecell) " +
            "VALUES (@id, @indexid,@year,@month,@day,@hour,@zsp,@planvalueproductionges,@planvalueproductionaes,@planvalueproductiontes," +
            "@sumtminges,@sumtminaes,@sumtmintes,@sumtgminges,@sumtgminaes,@sumtgmintes,@sumtmaxges,@sumtmaxaes,@sumtmaxtes," +
            "@planvaluedemand,@planvalueexport,@planvalueimport,@averpricebuy,@averpricecell)", sqlConnection);
            }
            else
            {
                //100 сек долго... но просто обновлять еще дольше 
                if (CompareTableMain(item, db.TableMain.Where(x => x.id == item.id).First()))
                    sqlCommand = new SqlCommand("UPDATE [TableMain] SET " +
                "id = @id, indexid = @indexid, year = @year, month = @month, day = @day, hour = @hour, zsp = @zsp," +
                "planvalueproductionges = @planvalueproductionges, planvalueproductionaes = @planvalueproductionaes, planvalueproductiontes = @planvalueproductiontes," +
                "sumtminges = @sumtminges, sumtminaes = @sumtminaes, sumtmintes = @sumtmintes, sumtgminges = @sumtgminges, sumtgminaes = @sumtgminaes, sumtgmintes = @sumtgmintes," +
                "sumtmaxges = @sumtmaxges, sumtmaxaes = @sumtmaxaes, sumtmaxtes = @sumtmaxtes, planvaluedemand = @planvaluedemand, planvalueexport = @planvalueexport, " +
                "planvalueimport = @planvalueimport, averpricebuy = @averpricebuy, averpricecell = @averpricecell where id = '" + item.id + "'", sqlConnection);
                else
                    return;
            }
            InputParam(ref sqlCommand, item);
            sqlCommand.ExecuteNonQuery();
        }

        private static void InputParam(ref SqlCommand sqlCommand, TableMain item)
        {
            sqlCommand.Parameters.AddWithValue("averpricebuy", item.averpricebuy);
            sqlCommand.Parameters.AddWithValue("averpricecell", item.averpricecell);
            sqlCommand.Parameters.AddWithValue("day", item.day);
            sqlCommand.Parameters.AddWithValue("hour", item.hour);

            sqlCommand.Parameters.AddWithValue("id", item.id);
            sqlCommand.Parameters.AddWithValue("indexid", item.indexid);
            sqlCommand.Parameters.AddWithValue("month", item.month);

            sqlCommand.Parameters.AddWithValue("year", item.year);
            sqlCommand.Parameters.AddWithValue("zsp", item.zsp);

            sqlCommand.Parameters.AddWithValue("planvaluedemand", item.planvaluedemand);
            sqlCommand.Parameters.AddWithValue("planvalueexport", item.planvalueexport);
            sqlCommand.Parameters.AddWithValue("planvalueimport", item.planvalueimport);
            sqlCommand.Parameters.AddWithValue("planvalueproductionaes", item.planvalueproductionaes);
            sqlCommand.Parameters.AddWithValue("planvalueproductionges", item.planvalueproductionges);
            sqlCommand.Parameters.AddWithValue("planvalueproductiontes", item.planvalueproductiontes);

            sqlCommand.Parameters.AddWithValue("sumtgminaes", item.sumtgminaes);
            sqlCommand.Parameters.AddWithValue("sumtgminges", item.sumtgminges);
            sqlCommand.Parameters.AddWithValue("sumtgmintes", item.sumtgmintes);
            sqlCommand.Parameters.AddWithValue("sumtmaxaes", item.sumtmaxaes);
            sqlCommand.Parameters.AddWithValue("sumtmaxges", item.sumtmaxges);
            sqlCommand.Parameters.AddWithValue("sumtmaxtes", item.sumtmaxtes);
            sqlCommand.Parameters.AddWithValue("sumtminaes", item.sumtminaes);
            sqlCommand.Parameters.AddWithValue("sumtminges", item.sumtminges);
            sqlCommand.Parameters.AddWithValue("sumtmintes", item.sumtmintes);
        }
        private static bool CompareTableMain(TableMain tableMain1, TableMain tableMain2)
        { 
            //Ничего лучше не придумал...
            if (tableMain1.id == tableMain2.id &
                tableMain1.indexid == tableMain2.indexid &
                tableMain1.hour == tableMain2.hour &
                tableMain1.year == tableMain2.year &
                tableMain1.day == tableMain2.day &
                tableMain1.averpricebuy == tableMain2.averpricebuy &
                tableMain1.averpricecell == tableMain2.averpricecell &
                tableMain1.month == tableMain2.month &
                tableMain1.planvaluedemand == tableMain2.planvaluedemand &
                tableMain1.planvalueexport == tableMain2.planvalueexport &
                tableMain1.planvalueimport == tableMain2.planvalueimport &
                tableMain1.planvalueproductionaes == tableMain2.planvalueproductionaes &
                tableMain1.planvalueproductionges == tableMain2.planvalueproductionges &
                tableMain1.planvalueproductiontes == tableMain2.planvalueproductiontes &
                tableMain1.sumtgminaes == tableMain2.sumtgminaes &
                tableMain1.sumtgminges == tableMain2.sumtgminges &
                tableMain1.sumtgmintes == tableMain2.sumtgmintes &
                tableMain1.sumtmaxaes == tableMain2.sumtmaxaes &
                tableMain1.sumtmaxges == tableMain2.sumtmaxges &
                tableMain1.sumtmaxtes == tableMain2.sumtmaxtes &
                tableMain1.sumtminaes == tableMain2.sumtminaes &
                tableMain1.sumtminges == tableMain2.sumtminges &
                tableMain1.sumtmintes == tableMain2.sumtmintes &
                tableMain1.zsp == tableMain2.zsp)
                return false;
            else
                return true;
        }
    }
}
