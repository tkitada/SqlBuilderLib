using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilderLib.ClauseReturn
{
    public class SelectRet
    {
        private readonly StringBuilder builder_;

        public SelectRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public SelectFromRet From(string arg)
        {
            return Util.SelectFrom(builder_, arg);
        }
    }
}
