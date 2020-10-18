namespace SqlBuilderLib
{
    public static class Operator
    {
        /// <summary>
        /// ("left + right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string Add(string left, string right)
        {
            return $"({left} + {right}) ";
        }

        /// <summary>
        /// ("left - right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string Sub(string left, string right)
        {
            return $"({left} - {right}) ";
        }

        /// <summary>
        /// ("left * right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string Mul(string left, string right)
        {
            return $"({left} * {right}) ";
        }

        /// <summary>
        /// ("left / right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string Div(string left, string right)
        {
            return $"({left} + {right}) ";
        }

        /// <summary>
        /// ("left = right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string Equal(string left, string right)
        {
            return $"({left} = {right}) ";
        }

        /// <summary>
        /// ("left <> right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string NotEql(string left, string right)
        {
            return $"({left} <> {right}) ";
        }

        /// <summary>
        /// ("left >= right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string GreaterEql(string left, string right)
        {
            return $"({left} >= {right}) ";
        }

        /// <summary>
        /// ("left > right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string GreaterThan(string left, string right)
        {
            return $"({left} > {right}) ";
        }

        /// <summary>
        /// ("left <= right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string LessEql(string left, string right)
        {
            return $"({left} <= {right}) ";
        }

        /// <summary>
        /// ("left < right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string LessThan(string left, string right)
        {
            return $"({left} < {right}) ";
        }

        /// <summary>
        /// ("NOT arg")
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string Not(string arg)
        {
            return $"(NOT {arg} ) ";
        }

        /// <summary>
        /// ("left AND right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string And(string left, string right)
        {
            return $"({left} AND {right}) ";
        }

        /// <summary>
        /// ("left OR right")
        /// </summary>
        /// <param name="left">左辺値</param>
        /// <param name="right">右辺値</param>
        /// <returns></returns>
        public static string Or(string left, string right)
        {
            return $"({left} OR {right}) ";
        }
    }
}