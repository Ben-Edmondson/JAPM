﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAPM.ClassLibrary.Models
{
    public class UsernameAndPassword : AppToSave
    {
#nullable disable
        public string Username { get; set; }
        public string Password { get; set; }
#nullable enable
    }
}
