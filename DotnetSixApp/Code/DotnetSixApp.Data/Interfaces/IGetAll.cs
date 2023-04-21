using System.Collections.Generic;

namespace DotnetSixApp.Data.Interfaces
{
    public interface IGetAll<out T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
