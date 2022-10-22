using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace BlazorControlWork.Data
{
    public class User
    {
        [BsonId]
        public ObjectId _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public User(string name, string surname, string email, string password, string login)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Login = login;
        }
    }
}
