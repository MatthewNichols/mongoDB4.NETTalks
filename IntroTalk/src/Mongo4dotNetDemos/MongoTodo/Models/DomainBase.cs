using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoTodo.Models
{
    public abstract class DomainBase
    {
        public ObjectId Id { get; set; }
    }
}
