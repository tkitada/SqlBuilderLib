using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class UpdateRet : RetBase
    {
        public UpdateRet(StringBuilder builder) : base(builder)
        {
        }

        public SetRet Set(params (string column, string arg)[] args)
        {
            return Util.Set(builder_, args);
        }
    }
}