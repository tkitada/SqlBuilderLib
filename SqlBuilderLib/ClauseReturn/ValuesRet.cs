using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class ValuesRet
    {
        private readonly StringBuilder builder_;

        public ValuesRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}