﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTsys.DataObjects
{
    public class QiaotaiObject
    {
        public override string ToString()
        {
            string result = "";
            var t = this.GetType();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                result += prop.Name + "：" + prop.GetValue(this) + "; ";
            }
            return result;
        }
    }
}
