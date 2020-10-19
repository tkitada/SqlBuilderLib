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
using static SqlBuilderLib.Simbol;
using static SqlBuilderLib.Operator;

namespace SqlBuilderLib.TestView
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly string dataSource_ = @"..\test.db";

        private const string SHOHIN = "Shohin";
        private const string SHOHIN_ID = "shohin_id";
        private const string SHOHIN_MEI = "shohin_mei";
        private const string SHOHIN_BUNRUI = "shohin_bunrui";
        private const string HANBAI_TANKA = "hanbai_tanka";
        private const string SHIIRE_TANKA = "shiire_tanka";
        private const string TOROKUBI = "torokubi";
        public MainWindow()
        {
            InitializeComponent();

            var connectionString = new SQLiteConnectionStringBuilder { DataSource = dataSource_ }.ToString();
            var dataTable = new DataTable();
            var builder = new SqlBuilder();
            var sql = builder
                .Select(SHOHIN_ID, SHOHIN_MEI, HANBAI_TANKA, SHIIRE_TANKA)
                .From(SHOHIN)
                .OrderBy(SHIIRE_TANKA)
                .End();
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                using (var command = new SQLiteCommand(sql, connection))
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    connection.Open();
                    AddParams(command,
                        ("@name", DbType.String, "衣服"));
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
