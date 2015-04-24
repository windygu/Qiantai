﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTsys.DataObjects
{
    class LogonToken
    {
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public DateTime LogonTime { get; set; }
        public DateTime LastOperationTime { get; set; }
    }
}