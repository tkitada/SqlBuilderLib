﻿using System.Text;

namespace SqlBuilderLib.ClauseReturn
{
    public class FromRet
    {
        private readonly StringBuilder builder_;

        public FromRet(StringBuilder builder)
        {
            builder_ = builder;
        }

        public WhereRet Where(string condition)
        {
            return Util.Where(builder_, condition);
        }

        public GroupByRet GroupBy(params string[] args)
        {
            return Util.GroupBy(builder_, args);
        }

        public OrderByRet OrderBy(params string[] args)
        {
            return Util.OrderBy(builder_, args);
        }

        public string End()
        {
            return Util.End(builder_);
        }
    }
}