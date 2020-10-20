using System.Text;

namespace SqlBuilderLib.Clauses
{
    public class WhereClause : Clause
    {
        public WhereClause(StringBuilder builder)
        {
            Builder = builder;
        }
        public override string ToString()
        {
            return Builder.ToString();
        }

    }
}