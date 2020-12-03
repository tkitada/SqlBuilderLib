using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class SelectDistinctRet : RetBase
    {
        public SelectDistinctRet(StringBuilder builder) : base(builder)
        {
        }

        public SelectFromRet From(string arg)
        {
            return Util.SelectFrom(builder_, arg);
        }

        public SelectFromRet From(string arg, string alias)
        {
            return Util.SelectFrom(builder_, arg, alias);
        }
    }
}