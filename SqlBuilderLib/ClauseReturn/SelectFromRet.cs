using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class SelectFromRet
    {
        private readonly StringBuilder builder_;

        public SelectFromRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public SelectFromWhereRet Where(string condition)
        {
            return Util.SelectFromWhere(builder_, condition);
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