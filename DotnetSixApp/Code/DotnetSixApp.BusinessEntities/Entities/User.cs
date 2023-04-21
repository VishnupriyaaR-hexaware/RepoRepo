using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotnetSixApp.BusinessEntities.Entities
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id  { get; set; }
        public int UserId  { get; set; }
        public string UserName  { get; set; }
        public int UserAge  { get; set; }
        public string UserPresent  { get; set; }
        
    }

}
