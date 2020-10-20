using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class DeleteFromWhereRet
    {
        private readonly StringBuilder builder_;

        public DeleteFromWhereRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}