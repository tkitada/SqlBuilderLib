using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public abstract class RetBase
    {
        protected readonly StringBuilder builder_;

        public RetBase(StringBuilder builder)
        {
            builder_ = builder;
        }
    }
}