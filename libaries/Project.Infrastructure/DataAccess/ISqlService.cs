namespace Project.Infrastructure.DataAccess
{
    public interface ISqlService
    {
        Task CommandAsync<T>(string storedProcedure, T parameter);
        Task<IEnumerable<T>> QueryAsync<T, U>(string storedProcedure, U parameter);
        Task<IEnumerable<T>> ExecuteAsync<T, U>(string query, U parameter);
        Task<IEnumerable<dynamic>> ExecuteAsync<U>(string query, U parameter);
    }
}