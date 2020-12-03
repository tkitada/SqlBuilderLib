using SqlBuilderLib.ClauseReturn;
using System.Text;

namespace SqlBuilderLib
{
    public static partial class SqlBuilder
    {

        public static SelectRet Select(params string[] args)
        {
            return Util.Select(new StringBuilder(), args);
        }

        public static SelectDistinctRet SelectDistinct(params string[] args)
        {
            return Util.SelectDistinct(new StringBuilder(), args);
        }

        public static InsertIntoRet InsertInto(string tableName, params string[] columns)
        {
            return Util.InsertInto(new StringBuilder(), tableName, columns);
        }

        public static DeleteFromRet DeleteFrom(string tableName)
        {
            return Util.DeleteFrom(new StringBuilder(), tableName);
        }

        public static UpdateRet Update(string tableName)
        {
            return Util.Update(new StringBuilder(), tableName);
        }
    }
}