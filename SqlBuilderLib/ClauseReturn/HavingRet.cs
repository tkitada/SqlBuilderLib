using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class HavingRet : RetBase
    {
        public HavingRet(StringBuilder builder) : base(builder)
        {
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