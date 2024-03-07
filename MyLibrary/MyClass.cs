namespace MyLibrary
{
    public class MyClass
    {
        public string GreetMe(string name)
        {
            MongoDB.Driver.MongoClient mongoClient = new MongoDB.Driver.MongoClient();
            MongoDB.Driver.IMongoDatabase mongoDatabase = mongoClient.GetDatabase("Valorant");
            MongoDB.Driver.IMongoCollection<Person> mongoCollection = mongoDatabase.GetCollection<Person>("people");
            Person person = new Person { Name = name };
            mongoCollection.InsertOne(person);
            


            return "hello " + name;
        }
    }
}