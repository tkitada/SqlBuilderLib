using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class WhereRet
    {
        private readonly StringBuilder builder_;

        public WhereRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public GroupByRet GroupBy(params string[] args)
        {
            return Util.GroupBy(builder_, args);
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}