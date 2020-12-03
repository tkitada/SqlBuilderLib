using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class OrderByRet : RetBase
    {
        public OrderByRet(StringBuilder builder) : base(builder)
        {
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}