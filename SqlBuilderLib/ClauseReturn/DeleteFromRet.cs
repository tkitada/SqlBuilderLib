using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class DeleteFromRet
    {
        private readonly StringBuilder builder_;

        public DeleteFromRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public DeleteFromWhereRet Where(string condition)
        {
            return Util.DeleteFromWhere(builder_, condition);
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}