namespace Project.Infrastructure.DataAccess
{
    public interface ISqlService
    {
        Task CommandAsync<T>(string storedProcedure, T parameter);
        Task<IEnumerable<T>> QueryAsync<T, U>(string storedProcedure, U parameter);
    }
}