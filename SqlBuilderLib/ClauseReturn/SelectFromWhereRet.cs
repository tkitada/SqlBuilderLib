using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class SelectFromWhereRet : RetBase
    {
        public SelectFromWhereRet(StringBuilder builder) : base(builder)
        {
        }

        public GroupByRet GroupBy(params string[] args)
        {
            return Util.GroupBy(builder_, args);
        }

        public OrderByRet OrderBy(params string[] args)
        {
            return Util.OrderBy(builder_, args);
        }

        public string End()
        {
            return Util.End(builder_);
        }
        public string EndWithBrackets()
        {
            return Util.EndWithBrackets(builder_);
        }
    }
}