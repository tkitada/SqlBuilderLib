using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class GroupByRet : RetBase
    {
        public GroupByRet(StringBuilder builder) : base(builder)
        {
        }

        public HavingRet Having(string condition)
        {
            return Util.Having(builder_, condition);
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