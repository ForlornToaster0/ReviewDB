using DataAccess.Modles;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DataAccess
{
    public class Access
    {
        public List<UserInfo> DBAccess()
        {
            List<UserInfo> users = new();
            MongoClient dbClient = new("mongodb+srv://Samuel:Samuel9080@samuelsserver.v6vet.mongodb.net/test");

            var database = dbClient.GetDatabase("ReviewDB");

            var collection = database.GetCollection<BsonDocument>("UserInfo");

            var firstDocument = collection.Find(new BsonDocument()).ToList();
            foreach (var item in firstDocument)
            {
                users.Add(BsonSerializer.Deserialize<UserInfo>(item));

            }

            return users;
        }
    }
}