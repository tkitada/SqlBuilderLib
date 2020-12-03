namespace SqlBuilderLib
{
    public static partial class SqlBuilder
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
    }
}