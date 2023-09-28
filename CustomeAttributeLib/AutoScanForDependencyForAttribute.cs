﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeAttributeLib
{
    public class AutoScanForDependencyForAttribute:Attribute
    {
    }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    public class CodeChangeHistoryAttribute : Attribute
    {
        private readonly string _author;

        public string Description { get; set; }
        public DateTime ChageDateTime { get; set; }
        public bool IsBug { get; }

        public CodeChangeHistoryAttribute(string author, bool isBug=false)
        {
            _author = author;
            IsBug = isBug;
        }
    }
}
