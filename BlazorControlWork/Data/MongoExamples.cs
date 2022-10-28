using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class MongoExamples
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);

        }
        public static List<User> FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static User Find(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Login == login).FirstOrDefault();
            return one;
        }

        public static void ReplaceByName(string login, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Login == login, user);
        }
    }
}
