using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBTest
{
    class Item
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Your MongoDB Interactions will go here
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<Item>("test_collection");

            // Sample Insert
            var newItem = new Item { Name = "Test Item 101", Quantity = 101};
            collection.InsertOne(newItem);
            Console.WriteLine("Item inserted with ID: " + newItem.Id);
            Console.WriteLine("Total Items: " + collection.CountDocuments(new BsonDocument()));
        }
    }
}
