using MongoDB.Bson;

class Item  // A simple data model
{
  public Item(string name)
  {
    Name = name;
  }

  public ObjectId Id { get; set; }
  public string? Name { get; set; }
  public int Quantity { get; set; }
}

