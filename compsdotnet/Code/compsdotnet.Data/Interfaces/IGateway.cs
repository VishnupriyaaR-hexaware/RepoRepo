using MongoDB.Driver;

namespace compsdotnet.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
