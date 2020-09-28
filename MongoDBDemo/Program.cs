using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            //User user = new User {
            //    Username = "sabinaya",
            //    Password = "kajan1997",
            //    UserDetail = new UserDetail{
            //        FirstName = "Pankajan",
            //        LastName = "Sabinaya",
            //        Address = "Earlalai East, Earlalai, Jaffna.",
            //        phoneNo = "0774961705",
            //        Nic = "199713800586v"
            //    }
            //};
            //db.InsertRecord("Users", user);

            //var records = db.LoadRecords<User>("Users");

            //foreach (var rec in records)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.UserDetail.FirstName} {rec.UserDetail.LastName}");
            //}

            var oneRec = db.LoadRecordById<User>("Users", new Guid("3501d41e-ec51-4e9d-9c93-055daec4b5d4"));
            //oneRec.UserDetail.DateOfBirth = new DateTime(1997, 05, 10, 0, 0, 0, DateTimeKind.Utc);
            //db.UpdateRecord<User>("Users", oneRec.Id, oneRec);

            db.DeleteRecord<User>("Users", oneRec.Id);

        }
    }
}
