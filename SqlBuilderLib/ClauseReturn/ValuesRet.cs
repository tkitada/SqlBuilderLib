using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class ValuesRet : RetBase
    {
        public ValuesRet(StringBuilder builder) : base(builder)
        {
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}