using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment1.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int inst_Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }

    }
}
