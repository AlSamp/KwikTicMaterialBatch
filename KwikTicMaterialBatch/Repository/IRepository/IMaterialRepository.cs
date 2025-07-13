using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Repository.IRepository
{
    public interface IMaterialRepository
    {
        public Task<Material> CreateMaterial(Material material); //

        public Task<Material> UpdateMaterial(Material material); // Update a specific Material

        public Task<bool> DeleteMaterial(int id); // Delete a specific Material by its ID

        public Task<Material> GetMaterialById(int materialId); // Get a specific Material by its ID

        public Task<IEnumerable<Material>> GetAllMaterials(); // Get All Materials
    }
}
