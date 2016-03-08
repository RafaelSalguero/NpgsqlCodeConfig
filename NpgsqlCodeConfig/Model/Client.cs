﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpgsqlCodeConfig.Model
{
    public class Client
    {
        [Key]
        public int IdReg { get; set; }
        public string Name { get; set; }
    }
}