using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class SetRet : RetBase
    {
        public SetRet(StringBuilder builder) : base(builder)
        {
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