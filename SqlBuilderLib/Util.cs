using SqlBuilderLib.ClauseReturn;
using System.Text;

namespace SqlBuilderLib
{
    internal static class Util
    {
        public static SelectRet Select(StringBuilder builder, string[] args)
        {
            builder.Append($"SELECT ");
            EnumerateArgs(builder, args);
            return new SelectRet(builder);
        }

        public static SelectFromRet SelectFrom(StringBuilder builder, string arg)
        {
            builder.Append($"FROM {arg} ");
            return new SelectFromRet(builder);
        }

        public static SelectFromWhereRet SelectFromWhere(StringBuilder builder, string condition)
        {
            builder.Append($"WHERE {condition} ");
            return new SelectFromWhereRet(builder);
        }

        public static GroupByRet GroupBy(StringBuilder builder, string[] args)
        {
            builder.Append($"GROUP BY ");
            EnumerateArgs(builder, args);
            return new GroupByRet(builder);
        }

        public static HavingRet Having(StringBuilder builder, string condition)
        {
            builder.Append($"HAVING {condition} ");
            return new HavingRet(builder);
        }

        public static OrderByRet OrderBy(StringBuilder builder, params string[] args)
        {
            builder.Append($"ORDER BY ");
            EnumerateArgs(builder, args);
            return new OrderByRet(builder);
        }

        public static InsertIntoRet InsertInto(StringBuilder builder, string tableName, params string[] columns)
        {
            builder.Append($"INSERT INTO {tableName} ");
            EnumerateArgsWithBrackets(builder, columns);
            return new InsertIntoRet(builder);
        }

        public static ValuesRet Values(StringBuilder builder, params string[] values)
        {
            builder.Append($"VALUES ");
            EnumerateArgsWithBrackets(builder, values);
            return new ValuesRet(builder);
        }

        public static DeleteFromRet DeleteFrom(StringBuilder builder, string tableName)
        {
            builder.Append($"DELETE FROM {tableName} ");
            return new DeleteFromRet(builder);
        }

        public static DeleteFromWhereRet DeleteFromWhere(StringBuilder builder, string condition)
        {
            builder.Append($"WHERE {condition} ");
            return new DeleteFromWhereRet(builder);
        }

        public static UpdateRet Update(StringBuilder builder, string tableName)
        {
            builder.Append($"UPDATE {tableName} ");
            return new UpdateRet(builder);
        }

        public static SetRet Set(StringBuilder builder, (string column, string arg)[] args)
        {
            builder.Append($"Set ");
            if (args.Length != 0)
            {
                foreach (var (column, arg) in args)
                {
                    builder.Append($"{column} = {arg}, ");
                }
                builder.Remove(builder.Length - 2, 1);
            }
            return new SetRet(builder);
        }

        public static UpdateSetWhereRet UpdateSetWhere(StringBuilder builder, string condition)
        {
            builder.Append($"WHERE {condition} ");
            return new UpdateSetWhereRet(builder);
        }

        public static string End(StringBuilder builder)
        {
            var sql = builder.ToString();
            builder.Clear();
            return sql;
        }

        /// <summary>
        /// argsをカンマ区切りで列挙した文字列をbuilderに追加する<br></br>
        /// 例: "arg1, arg2, arg3 "<br></br>
        /// argsが無い場合は何も追加しない
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="args"></param>
        private static void EnumerateArgs(StringBuilder builder, string[] args)
        {
            if (args.Length == 0) return;
            foreach (var arg in args)
            {
                builder.Append($"{arg}, ");
            }
            builder.Remove(builder.Length - 2, 1);
        }

        /// <summary>
        /// argsをカンマ区切りで列挙しかっこでくくった文字列をbuilderに追加する <br></br>
        /// 例: "(arg1, arg2, arg3 )"<br></br>
        /// argsが無い場合は何も追加しない
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="args"></param>
        private static void EnumerateArgsWithBrackets(StringBuilder builder, string[] args)
        {
            if (args.Length == 0) return;
            builder.Append("(");
            foreach (var arg in args)
            {
                builder.Append($"{arg}, ");
            }
            builder.Remove(builder.Length - 2, 1);
            builder.Append(") ");
        }
    }
}