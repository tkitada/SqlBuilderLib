using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class DeleteFromWhereRet: RetBase
    {

        public DeleteFromWhereRet(StringBuilder builder):base(builder)
        {
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}