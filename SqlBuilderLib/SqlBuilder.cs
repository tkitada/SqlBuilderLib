using SqlBuilderLib.ClauseReturn;
using System.Text;

namespace SqlBuilderLib
{
    public class SqlBuilder
    {
        private readonly StringBuilder builder_ = new StringBuilder();

        public SelectRet Select(params string[] args)
        {
            return Util.Select(builder_, args);
        }
    }
}