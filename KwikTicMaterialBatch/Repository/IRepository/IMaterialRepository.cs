using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Repository.IRepository
{
    public interface IMaterialRepository
    {
        public Material CreateMaterial(Material material); //

        public Material UpdateMaterial(Material material); // Update a specific Material

        public bool DeleteMaterial(int id); // Delete a specific Material by its ID

        public Material GetMaterialById(int materialId); // Get a specific Material by its ID

        public IEnumerable<Material> GetAllMaterials(); // Get All Materials
    }
}
