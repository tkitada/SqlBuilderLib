using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class HavingRet
    {
        private readonly StringBuilder builder_;

        public HavingRet(StringBuilder builder)
        {
            builder_ = builder;
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