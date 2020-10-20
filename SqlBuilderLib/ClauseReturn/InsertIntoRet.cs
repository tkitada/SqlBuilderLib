using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class InsertIntoRet
    {
        private readonly StringBuilder builder_;

        public InsertIntoRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public SelectRet Select(params string[] args)
        {
            return Util.Select(builder_, args);
        }

        public ValuesRet Values(params string[] values)
        {
            return Util.Values(builder_, values);
        }
    }
}