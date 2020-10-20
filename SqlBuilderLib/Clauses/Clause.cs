using System.Text;

namespace SqlBuilderLib.Clauses
{
    public abstract class Clause
    {
        internal StringBuilder Builder { get; set; }
    }
}