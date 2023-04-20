namespace Project.Services.SeedData
{
    public interface ISeedDataService
    {
        Task<bool> SeedCoreData();
    }
}