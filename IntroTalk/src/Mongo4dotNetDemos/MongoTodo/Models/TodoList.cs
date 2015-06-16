using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoTodo.Models
{
    public class TodoList : DomainBase
    {
        public string Name { get; set; }
        //public DateTime DateCreated { get; set; }
        //public DateTime DateUpdated { get; set; }

        public List<TodoListItem> Items { get; set; }
    }
}
