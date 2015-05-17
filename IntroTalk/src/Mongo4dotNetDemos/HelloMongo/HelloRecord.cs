using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace HelloMongo
{
    public class HelloRecord
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public DateTime When { get; set; }

    }
}
