using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

using System.Data.SQLite;
using static SqlBuilderLib.Function;
using static SqlBuilderLib.Keyword;
using static SqlBuilderLib.Operator;

namespace SqlBuilderLib.TestView
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly string dataSource_ = @"..\test.db";

        private const string T_SHOHIN = "Shohin";
        private const string T_SHOHIN_INS = "ShohinIns";
        private const string T_SHOHIN_COPY = "ShohinCopy";
        private const string T_SHOHIN_BUNRUI = "ShohinBunrui";

        private const string SHOHIN_ID = "shohin_id";
        private const string SHOHIN_MEI = "shohin_mei";
        private const string SHOHIN_BUNRUI = "shohin_bunrui";
        private const string HANBAI_TANKA = "hanbai_tanka";
        private const string SUM_HANBAI_TANKA = "sum_hanbai_tanka";
        private const string SHIIRE_TANKA = "shiire_tanka";
        private const string SUM_SHIIRE_TANKA = "sum_shiire_tanka";
        private const string TOROKUBI = "torokubi";
        public MainWindow()
        {
            InitializeComponent();

            var connectionString = new SQLiteConnectionStringBuilder { DataSource = dataSource_ }.ToString();
            var dataTable = new DataTable();
            var builder = new SqlBuilder();
            var sql = builder
                .Select(SHOHIN_BUNRUI, "cnt_shohin")
                .From(SubQuery(new SqlBuilder()
                    .Select(ALL)
                    .From(SubQuery(new SqlBuilder()
                        .Select(SHOHIN_BUNRUI, As(Count(ALL), "cnt_shohin"))
                        .From(T_SHOHIN)
                        .GroupBy(SHOHIN_BUNRUI)
                        .End()))
                    .Where(Equal("cnt_shohin", "2"))
                    .End()))
                .End();
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                using (var command = new SQLiteCommand(sql, connection))
                using(var adapter = new SQLiteDataAdapter(command))
                {
                    connection.Open();
                    AddParams(command,
                        ("@id", DbType.String, "0008"),
                        ("@name", DbType.String, "ボールペン"),
                        ("@bunrui", DbType.String, "キッチン用品"),
                        ("@htanka", DbType.Int32, 1000),
                        ("@stanka", DbType.Int32, 500),
                        ("@torokubi", DbType.Date, null)
                        );
                    adapter.Fill(dataTable);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            data_grid.ItemsSource = dataTable.DefaultView;
            text_block.Text = sql;
        }
        private void AddParams(SQLiteCommand command, params (string paraName, DbType type, object value)[] args)
        {
            foreach (var (paraName, type, value) in args)
            {
                command.Parameters.Add(new SQLiteParameter(paraName, value) { DbType = type });
            }
        }
    }
}
