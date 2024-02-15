# How to set up a simple MongoDB project to focus on the basics of MongoDB and C# connectivity

## **Prerequisites**

1. **MongoDB Account and Database:**
   * If you haven't already, set up a free MongoDB Atlas account ([https://www.mongodb.com/atlas/database](https://www.mongodb.com/atlas/database)) or install MongoDB locally.
   * Create a new database within your MongoDB setup (name it something like "myTestDatabase").

2. **MongoDB C# Driver:**
   * **Visual Studio:**  Use the NuGet Package Manager to add the `MongoDB.Driver` package to your project.
   * **VS Code:** In the terminal, type `dotnet add package MongoDB.Driver`

## **Project Structure: Console Application**

1. **New Project:** Create a new C# console application (.NET Core or .NET Framework will work). You can name it "MongoSimpleStorage".

2. **Basic C# Class (Example):**

   ```csharp
   using MongoDB.Bson; 
   using MongoDB.Driver;

   namespace MongoSimpleStorage
   {
       class Item  // A simple data model
       {
           public ObjectId Id { get; set; } 
           public string Name { get; set; }
           public int Quantity { get; set; } 
       }

       class Program
       {
           static void Main(string[] args)
           {
               // ... MongoDB connection and operations will go here ...
           }
       }
   }
   ```

## **Implementation Steps**

1. **Connect to MongoDB:**

   ```csharp
   var client = new MongoClient("your_mongodb_connection_string"); 
   var database = client.GetDatabase("myTestDatabase"); 
   var collection = database.GetCollection<Item>("items"); // Get 'items' collection
   ```

   * Replace `"your_mongodb_connection_string"` with your actual Atlas connection string (found in your Atlas dashboard) or your local MongoDB connection string.

2. **Insert Data:**

   ```csharp
   var newItem = new Item { Name = "Test Item", Quantity = 5 };
   collection.InsertOne(newItem); 
   Console.WriteLine("Item inserted with ID: " + newItem.Id); 
   ```

3. **Read Data:**

   ```csharp
   var filter = Builders<Item>.Filter.Eq("Name", "Test Item"); // Simple filter
   var result = collection.Find(filter).FirstOrDefault();

   if (result != null)
   { 
       Console.WriteLine("Name: " + result.Name + ", Quantity: " + result.Quantity);
   }
   ```

## **Running and Testing**

Build and run your console application. It should insert the test item and then retrieve it, printing the details.

## **Things to Note**

* **ObjectId:** MongoDB uses `ObjectId` as its primary key type.
* **Collections:** Think of collections as being similar to tables in traditional databases.
* **MongoDB Documentation:** The official MongoDB manual has in-depth explanations with lots of examples: [https://docs.mongodb.com/](https://docs.mongodb.com/)

## **Next Steps**

* **Multiple Documents:** Experiment with inserting and retrieving multiple documents.
* **Updates:** Learn how to use `UpdateOne` or `UpdateMany` to modify existing data in MongoDB.
* **Deletes:** Practice using `DeleteOne` or  `DeleteMany` to remove items from your collection.
