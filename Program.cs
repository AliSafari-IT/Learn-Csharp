using MongoDB.Driver;



class Program
{
  // Main2 function to perform operations with MongoDB using C# driver.
  static void Main(string[] args)
  {
    var client = new MongoClient("mongodb://localhost:27017");
    var database = client.GetDatabase("test");
    Console.WriteLine("Connected to MongoDB" + database.DatabaseNamespace);
    var collection = database.GetCollection<Item>("item_collection"); // Get 'items' collection

    var newItem = new Item("Test Item") { Quantity = 5 };
    collection.InsertOne(newItem);
    Console.WriteLine("Item inserted with ID: " + newItem.Id);

    var filter = Builders<Item>.Filter.Eq("Name", "Test Item"); // Simple filter
    var result = collection.Find(filter).FirstOrDefault();

    if (result != null)
    {
      Console.WriteLine("Name: " + result.Name + ", Quantity: " + result.Quantity);
    }
  }
}

