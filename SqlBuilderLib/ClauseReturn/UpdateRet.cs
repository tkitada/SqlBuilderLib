using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class UpdateRet
    {
        private readonly StringBuilder builder_;

        public UpdateRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public SetRet Set(params (string column, string arg)[] args)
        {
            return Util.Set(builder_, args);
        }
    }
}