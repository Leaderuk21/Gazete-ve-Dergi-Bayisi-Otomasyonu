using ClosedXML.Excel;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace Face
{
    public class Util
    {
        public static string cnnstring = "Data Source=localhost\\sqlexpress;Initial Catalog=VTYS;Integrated Security=True";
        public static int Yurut(SqlCommand cmd)
        {
            int etkilenensatir = -1;
            try
            {
                cmd.Connection.Open();
                etkilenensatir = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return etkilenensatir;
        }

        public static bool VeriTabaniYedekle()
        {
            bool eylem = false;
            SqlConnection cnn = new SqlConnection(cnnstring);
            SqlCommand cmd = new SqlCommand("BACKUP DATABASE [VTYS] TO DISK = 'C:\\Yedekler\\VeritabaniYedegi.bak' WITH FORMAT;", cnn);
            try
            {
                if (cnn.State==ConnectionState.Closed)
                    cnn.Open();
                cmd.ExecuteNonQuery();
                eylem = true;
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            return eylem;
        }

        public static bool VeriTabaniYedekDon()
        {
            bool eylem = false;
            SqlConnection cnn = new SqlConnection(cnnstring);
            SqlCommand cmd = new SqlCommand("USE master; ALTER DATABASE [VTYS] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                                          "RESTORE DATABASE [VTYS] FROM DISK = 'C:\\Yedekler\\VeritabaniYedegi.bak' WITH REPLACE; " +
                                          "ALTER DATABASE [VTYS] SET MULTI_USER;", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                cmd.ExecuteNonQuery();
                eylem = true;
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            return eylem;
        }
        public static void panelListele(Panel panel)
        {
            int item_sayi = 0;
            foreach (Control control in panel.Controls)
                item_sayi++;
            int genislik = panel.Width / (item_sayi + 1);
            int basnokta = genislik / (item_sayi * 2);
            int i = 0;
            foreach (Control control in panel.Controls)
            {
                control.Width = genislik;
                control.Location = new Point(genislik * i + basnokta * 2 * i + basnokta, control.Location.Y);
                i++;
            }
        }

        public static DataTable ImportDataFromExcel(string filePath)
        {
            DataTable table = new DataTable();
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                bool firstRow = true;
                foreach (var row in ws.RowsUsed())
                {
                    if (firstRow)
                    {
                        foreach (var cell in row.CellsUsed())
                        {
                            table.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        table.Rows.Add();
                        int i = 0;
                        foreach (var cell in row.CellsUsed())
                        {
                            table.Rows[table.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }
            }
            return table;
        }


        public static void ExportDataToExcel(DataTable dataTable, string filePath)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");
                worksheet.Cell(1, 1).InsertTable(dataTable);
                workbook.SaveAs(filePath);
            }
        }

        public static string DateCSql(DateTime tarih) { return tarih.ToString("yyyy-MM-dd HH:mm:ss.fff"); }
    }
}
