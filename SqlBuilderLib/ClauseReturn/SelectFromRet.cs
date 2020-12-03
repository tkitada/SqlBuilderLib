using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class SelectFromRet : RetBase
    {
        public SelectFromRet(StringBuilder builder) : base(builder)
        {
        }

        public InnerJoinRet InnerJoin(string tableName, string alias = null)
        {
            return Util.InnerJoin(builder_, tableName, alias);
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
        public string EndWithBrackets()
        {
            return Util.EndWithBrackets(builder_);
        }
    }
}