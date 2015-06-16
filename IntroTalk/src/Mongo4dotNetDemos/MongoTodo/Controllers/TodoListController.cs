using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web.OData.Query;
using MongoDB.Bson;
using MongoTodo.DTOs;
using MongoTodo.Models;
using MongoTodo.Repositories;

namespace MongoTodo.Controllers
{
    [RoutePrefix("api/todolist")]
    public class TodoListController : ApiController
    {
        //Usually I would get the repository via dependency injection...but that is not what this code example is about.
        private TodoListRepository GetRepository()
        {
            return new TodoListRepository(ConfigurationManager.ConnectionStrings["todoListDb"].ConnectionString);
        }

        // GET api/<controller>
        public async Task<IEnumerable<TodoListId>> Get(ODataQueryOptions opts)
        {
            var skip = opts.Skip == null ? 0 : opts.Skip.Value;
            var top = opts.Top == null ? 10 : opts.Top.Value;
            var todoLists = await GetRepository().GetAll(skip, top);
            return todoLists.Select(td => new TodoListId
            {
                Name = td.Name,
                Id = td.Id.ToString()
            });
        }

        // GET api/<controller>/5
        public async Task<TodoList> Get(string id)
        {
            var objectId = ObjectId.Parse(id);
            var todoList = await GetRepository().GetById(objectId);
            return todoList;
        }

        // POST api/<controller>
        public async Task<TodoList> Post(TodoList value)
        {
            return await GetRepository().Insert(value);
        }

        // PUT api/<controller>/5
        public async void Put(string id, TodoList value)
        {
            var objectId = ObjectId.Parse(id);
            await GetRepository().Update(objectId, value);
        }

        // DELETE api/<controller>/5
        public async void Delete(string id)
        {
            var objectId = ObjectId.Parse(id);
            await GetRepository().Delete(objectId);
        }

        [Route("savelistitem")]
        public async Task<TodoListItem> SaveListItem(string listId, TodoListItem item)
        {
            var objectId = ObjectId.Parse(listId);
            TodoListItem newItem = await GetRepository().SaveListItem(objectId, item);
            return newItem;
        }
    }
}