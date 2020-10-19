using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class GroupByRet
    {
        private readonly StringBuilder builder_;

        public GroupByRet(StringBuilder builder)
        {
            builder_ = builder;
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
    }
}