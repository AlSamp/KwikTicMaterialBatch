using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Repository.IRepository
{
    public interface IKitRepository
    {
        public Task<Kit> CreateKitAsync(Kit kit); // Create a new Kit
        public Task<Kit> UpdateKitAsync(Kit kit); // Update a specific Kit
        public Task<bool> DeleteKitAsync(int id); // Delete a specific Kit by its ID
        public Task<Kit> GetKitByIdAsync(int kitId); // Get a specific Kit by its ID
        public Task<IEnumerable<Kit>> GetAllKitsAsync(); // Get All Kits
    }
}
