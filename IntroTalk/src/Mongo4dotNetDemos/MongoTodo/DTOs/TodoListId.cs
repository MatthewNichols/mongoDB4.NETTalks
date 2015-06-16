using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoTodo.DTOs
{
    public class TodoListId
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
