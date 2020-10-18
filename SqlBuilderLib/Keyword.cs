namespace SqlBuilderLib
{
    public static class Keyword
    {
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
    }
}