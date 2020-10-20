using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class SelectFromWhereRet
    {
        private readonly StringBuilder builder_;

        public SelectFromWhereRet(StringBuilder builder)
        {
            builder_ = builder;
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
    }
}