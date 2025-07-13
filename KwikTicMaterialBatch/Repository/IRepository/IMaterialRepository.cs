using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Repository.IRepository
{
    public interface IMaterialRepository
    {
        public Task<Material> CreateMaterialAsync(Material material); //

        public Task<Material> UpdateMaterialAsync(Material material); // Update a specific Material

        public Task<bool> DeleteMaterialAsync(int id); // Delete a specific Material by its ID

        public Task<Material> GetMaterialByIdAsync(int materialId); // Get a specific Material by its ID

        public Task<IEnumerable<Material>> GetAllMaterialsAsync(); // Get All Materials
    }
}
