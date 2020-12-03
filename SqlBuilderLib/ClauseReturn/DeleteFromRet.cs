using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class DeleteFromRet : RetBase
    {
        public DeleteFromRet(StringBuilder builder) : base(builder)
        {
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