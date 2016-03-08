using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpgsqlCodeConfig.Model
{
    public class Product
    {
        [Key]
        public int IdReg { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
