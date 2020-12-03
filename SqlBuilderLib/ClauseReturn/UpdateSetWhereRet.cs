using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class UpdateSetWhereRet : RetBase
    {
        public UpdateSetWhereRet(StringBuilder builder) : base(builder)
        {
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}