using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class OrderByRet
    {
        private readonly StringBuilder builder_;

        public OrderByRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}