using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoTodo.Models;

namespace MongoTodo.Repositories
{
    public class TodoListRepository : BaseRepository<TodoList>
    {
        public TodoListRepository(string connectionString) : base(connectionString)
        { }

        protected override string CollectionName
        {
            get { return "todoList"; }
        }

        public async Task<TodoListItem> SaveListItem(ObjectId listId, TodoListItem item)
        {
            var collection = GetCollection();

            //if new item
            if (item.Id == -1)
            {
                var updateDefinition = (new UpdateDefinitionBuilder<TodoList>()).AddToSet(l => l.Items, item);
                var filterDefinition = new ExpressionFilterDefinition<TodoList>(l => l.Id == listId);
                
                await collection.FindOneAndUpdateAsync(filterDefinition, updateDefinition);
                return item;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
