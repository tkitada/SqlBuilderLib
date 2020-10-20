using SqlBuilderLib.ClauseReturn;
using SqlBuilderLib.Clauses;
using System.Text;

namespace SqlBuilderLib
{
    public class SqlBuilder
    {
        private readonly StringBuilder builder_ = new StringBuilder();

        public SelectRet Select(params string[] args)
        {
            return Util.Select(builder_, args);
        }

        public InsertIntoRet InsertInto(string tableName, params string[] columns)
        {
            return Util.InsertInto(builder_, tableName, columns);
        }

        public DeleteFromRet DeleteFrom(string tableName)
        {
            return Util.DeleteFrom(builder_, tableName);
        }

        public UpdateRet Update(string tableName)
        {
            return Util.Update(builder_, tableName);
        }

        public static WhereClause Where(string condition)
        {
            var builder = new StringBuilder();
            builder.Append($"WHERE {condition} ");
            return new WhereClause(builder);
        }
    }
}