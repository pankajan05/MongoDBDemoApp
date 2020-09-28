using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDBDemo
{
    public class User
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
