using MongoDB.Driver;

namespace DotnetSixApp.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
