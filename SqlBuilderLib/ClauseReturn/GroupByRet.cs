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

        public string End()
        {
            return Util.End(builder_);
        }
    }
}