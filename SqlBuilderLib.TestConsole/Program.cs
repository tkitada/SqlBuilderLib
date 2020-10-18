using System.Data;
using System.Data.SQLite;
using static System.Console;
using static SqlBuilderLib.Function;
using static SqlBuilderLib.Keyword;
using static SqlBuilderLib.Simbol;
using static SqlBuilderLib.Operator;

namespace SqlBuilderLib.TestConsole
{
    internal class Program
    {
        private static readonly string dataSource_ = @"..\test.db";
        private const string SHOHIN_ID = "shohin_id";
        private const string SHOHIN_MEI = "shohin_mei";
        private const string SHOHIN_BUNRUI = "shohin_bunrui";
        private const string HANBAI_TANKA = "hanbai_tanka";
        private const string SHIIRE_TANKA = "shiire_tanka";
        private const string TOROKUBI = "torokubi";

        private const string SHOHIN = "Shohin";

        private static void Main()
        {
            var connectionStringBuilder = new SQLiteConnectionStringBuilder
            {
                DataSource = dataSource_
            };
            var connectionString = connectionStringBuilder.ToString();
            var dataTable = new DataTable();
            string sql;
            var builder = new SqlBuilder();
            sql = builder.Select(SHOHIN_MEI, SHIIRE_TANKA)
                         .From(SHOHIN)
                         .Where(And(Equal(SHOHIN_BUNRUI, "@bunrui"),
                                    GreaterEql(HANBAI_TANKA, "3000")))
                         .End();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(sql, connection))
            using (var adapter = new SQLiteDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@bunrui", "キッチン用品");
                adapter.Fill(dataTable);
            }
            foreach (DataColumn column in dataTable.Columns)
            {
                Write($"{column.ColumnName}\t");
            }
            WriteLine();
            foreach (var row in dataTable.AsEnumerable())
            {
                foreach (var item in row.ItemArray)
                {
                    Write($"{item}\t");
                }
                WriteLine();
            }
            WriteLine();
            dataTable.Reset();
        }
    }
}