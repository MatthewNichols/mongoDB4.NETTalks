using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace HelloMongo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hi, {0}", name);

            //Do the async Mongo stuff
            MainAsync(name).GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();

        }

        private static async Task MainAsync(string name)
        {
            //Connect to the DB
            var mongoClient = new MongoClient("mongodb://localhost");
            var mongoDatabase = mongoClient.GetDatabase("hello");

            //Get a reference to the collection
            var hellos = mongoDatabase.GetCollection<HelloRecord>("hellos");

            //SHow all of the others that have already been here
            Console.WriteLine("I have also meet these people:");
            using (var cursor = await hellos.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var helloRecord in batch)
                    {
                        Console.WriteLine("{0} on {1}", helloRecord.Name, helloRecord.When);
                    }
                }
            }

            await hellos.InsertOneAsync(new HelloRecord
            {
                Name = name,
                When = DateTime.Now
            });
            
        }

    }
}
