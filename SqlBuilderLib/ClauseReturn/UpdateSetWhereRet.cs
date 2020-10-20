using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class UpdateSetWhereRet
    {
        private readonly StringBuilder builder_;

        public UpdateSetWhereRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}