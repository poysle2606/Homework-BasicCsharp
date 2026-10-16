using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.OOP
{
    public class BaseEntity
    {
        public string id { get; set; }
        public long created_at { get; set; }
        public long updated_at { get; set; }
        public bool is_deleted { get; set; }
    }
}
