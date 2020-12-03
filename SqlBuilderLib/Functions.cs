namespace SqlBuilderLib
{
    public static partial class SqlBuilder
    {
        /// <summary>
        /// "COUNT(arg)"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Count(string arg)
        {
            return $"COUNT({arg})";
        }

        /// <summary>
        /// "SUM(arg)"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Sum(string arg)
        {
            return $"SUM({arg})";
        }

        /// <summary>
        /// "AVG(arg)"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Avg(string arg)
        {
            return $"AVG({arg})";
        }

        /// <summary>
        /// "MAX(arg)"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Max(string arg)
        {
            return $"MAX({arg})";
        }

        /// <summary>
        /// "MIN(arg)"
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Min(string arg)
        {
            return $"MIN({arg})";
        }
    }
}