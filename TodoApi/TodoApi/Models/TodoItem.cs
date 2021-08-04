using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }//Unique key in a relational database
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
