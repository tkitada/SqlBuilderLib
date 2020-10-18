﻿using SqlBuilderLib.ClauseReturn;
using System.Text;

namespace SqlBuilderLib
{
    internal static class Util
    {
        public static SelectRet Select(StringBuilder builder, string[] args)
        {
            builder.Append($"SELECT ");
            IterateArgs(builder, args);
            return new SelectRet(builder);
        }

        public static FromRet From(StringBuilder builder, string arg)
        {
            builder.Append($"FROM {arg} ");
            return new FromRet(builder);
        }

        public static WhereRet Where(StringBuilder builder, string arg)
        {
            builder.Append($"WHERE {arg} ");
            return new WhereRet(builder);
        }

        public static GroupByRet GroupBy(StringBuilder builder, string[] args)
        {
            builder.Append($"GROUP BY ");
            IterateArgs(builder, args);
            return new GroupByRet(builder);
        }

        public static string End(StringBuilder builder)
        {
            var sql = builder.ToString();
            builder.Clear();
            return sql;
        }

        private static void IterateArgs(StringBuilder builder, string[] args)
        {
            foreach (var arg in args)
            {
                builder.Append($"{arg}, ");
            }
            builder.Remove(builder.Length - 2, 1);
        }
    }
}