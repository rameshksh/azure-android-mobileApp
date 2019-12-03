using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsComplete { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
