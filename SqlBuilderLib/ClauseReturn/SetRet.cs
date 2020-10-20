using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class SetRet
    {
        private readonly StringBuilder builder_;

        public SetRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public UpdateSetWhereRet Where(string condition)
        {
            return Util.UpdateSetWhere(builder_, condition);
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}