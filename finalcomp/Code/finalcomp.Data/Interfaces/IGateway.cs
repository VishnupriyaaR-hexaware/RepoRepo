using MongoDB.Driver;

namespace finalcomp.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
