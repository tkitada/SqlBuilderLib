using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class FromRet
    {
        private readonly StringBuilder builder_;

        public FromRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public WhereRet Where(string arg)
        {
            return Util.Where(builder_, arg);
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