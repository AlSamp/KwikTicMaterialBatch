using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Repository.IRepository
{
    public interface IKitRepository
    {
        public Kit CreateKit(Kit kit); // Create a new Kit
        public Kit UpdateKit(Kit kit); // Update a specific Kit
        public bool DeleteKit(int id); // Delete a specific Kit by its ID
        public Kit GetKitById(int kitId); // Get a specific Kit by its ID
        public IEnumerable<Kit> GetAllKits(); // Get All Kits
    }
}
