namespace SqlBuilderLib
{
    public static class Keyword
    {
        public const string ALL = "*";
        public const string DEFAULT = "DEFAULT";

        /// <summary>
        /// "column AS alias"
        /// </summary>
        /// <param name="column">カラム名</param>
        /// <param name="alias">別名</param>
        /// <returns></returns>
        public static string As(string column, string alias)
        {
            return $"{column} AS {alias} ";
        }

        /// <summary>
        /// "DISTINCT arg"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Distinct(string arg)
        {
            return $"DISTINCT {arg} ";
        }

        /// <summary>
        /// "arg Asc"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Asc(string arg)
        {
            return $"{arg} Asc";
        }

        /// <summary>
        /// "arg Desc"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Desc(string arg)
        {
            return $"{arg} DESC";
        }

        public static string SubQuery(string subQuery, string alias = "")
        {
            return string.IsNullOrEmpty(alias) ? $"({subQuery}) " : $"({subQuery}) {alias} ";
        }
    }
}