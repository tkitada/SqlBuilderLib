namespace SqlBuilderLib
{
    public static partial class SqlBuilder
    {
        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left + right)"</returns>
        public static string Add(string left, string right)
        {
            return $"({left} + {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left - right)"</returns>
        public static string Sub(string left, string right)
        {
            return $"({left} - {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left * right)"</returns>
        public static string Mul(string left, string right)
        {
            return $"({left} * {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left / right)"</returns>
        public static string Div(string left, string right)
        {
            return $"({left} / {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left = right)"</returns>
        public static string Equal(string left, string right)
        {
            return $"({left} = {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left <> right)"</returns>
        public static string NotEql(string left, string right)
        {
            return $"({left} <> {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left >= right)"</returns>
        public static string GreaterEql(string left, string right)
        {
            return $"({left} >= {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left > right)"</returns>
        public static string GreaterThan(string left, string right)
        {
            return $"({left} > {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left <= right)"</returns>
        public static string LessEql(string left, string right)
        {
            return $"({left} <= {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left < right)"</returns>
        public static string LessThan(string left, string right)
        {
            return $"({left} < {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="arg"></param>
        /// <returns>"(NOT arg)"</returns>
        public static string Not(string arg)
        {
            return $"(NOT {arg} ) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left AND right)"</returns>
        public static string And(string left, string right)
        {
            return $"({left} AND {right}) ";
        }

        /// <summary>
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns>"(left OR right)"</returns>
        public static string Or(string left, string right)
        {
            return $"({left} OR {right}) ";
        }
    }
}