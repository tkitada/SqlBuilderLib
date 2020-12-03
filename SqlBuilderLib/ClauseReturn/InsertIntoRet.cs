using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class InsertIntoRet : RetBase
    {
        public InsertIntoRet(StringBuilder builder) : base(builder)
        {
        }

        public SelectRet Select(params string[] args)
        {
            return Util.Select(builder_, args);
        }

        public SelectDistinctRet SelectDistinct(params string[] args)
        {
            return Util.SelectDistinct(builder_, args);
        }

        public ValuesRet Values(params string[] values)
        {
            return Util.Values(builder_, values);
        }
    }
}