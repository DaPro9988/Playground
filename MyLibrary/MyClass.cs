using MongoDB.Driver;

namespace MyLibrary;

public class MyClass
{
    public string GreetMe(string name)
    {
        var mongoClient = new MongoClient();
        var mongoDatabase = mongoClient.GetDatabase("Valorant");
        var mongoCollection = mongoDatabase.GetCollection<Person>("people");
        var person = new Person { Name = name };
        mongoCollection.InsertOne(person);


        return "hello " + name;
    }
}