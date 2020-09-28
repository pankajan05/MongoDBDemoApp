using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            User user = new User {
                Username = "sabinaya",
                Password = "kajan1997",
                UserDetail = new UserDetail{
                    FirstName = "Pankajan",
                    LastName = "Sabinaya",
                    Address = "Earlalai East, Earlalai, Jaffna.",
                    phoneNo = "0774961705",
                    Nic = "199713800586v"
                }
            };
            db.InsertRecord("Users", user);
        }
    }

    public class User
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserDetail UserDetail { get; set; }
    }

    public class UserDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string phoneNo { get; set; }
        public string Nic { get; set; }
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
            Console.WriteLine("Connected Successfully!");

        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        

    }
}
