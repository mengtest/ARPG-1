﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaidouDatabase.Model {
    class TestUser {
        public virtual int Id { get; set; }
        public virtual string Username{get;set;}
        public virtual string Password { get; set; }
        public virtual int Age{get;set;}
    }
}
