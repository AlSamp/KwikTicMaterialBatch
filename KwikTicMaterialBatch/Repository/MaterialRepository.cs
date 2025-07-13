using KwikTicMaterialBatch.Data;
using KwikTicMaterialBatch.Data.Models;
using KwikTicMaterialBatch.Repository.IRepository;

namespace KwikTicMaterialBatch.Repository
{

    public class MaterialRepository : IMaterialRepository
    {
        private readonly ApplicationDbContext _db;

        public MaterialRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Material CreateMaterial(Material material)
        {
            _db.Materials.Add(material);
            _db.SaveChanges();
            return material;
        }

        public bool DeleteMaterial(int id)
        {
            var obj = _db.Materials.FirstOrDefault(u => u.KitId == id);

            if(obj is null)
            {
                return false;
            }
            else
            {
                _db.Remove(obj);
                return _db.SaveChanges() > 0;
                
            }
        }

        public IEnumerable<Material> GetAllMaterials()
        {
           return _db.Materials.ToList();
        }

        public Material GetMaterialById(int materialId)
        {
            var obj = _db.Materials.FirstOrDefault(u => u.MaterialID == materialId);
            if(obj is null)
            {
                return new Material(); // will return null
            }
            else
            {
                return obj;
            }
        }

        public Material UpdateMaterial(Material material)
        {
            var objectFromDb = _db.Materials.FirstOrDefault(u => u == material);

            if(objectFromDb is null)
            {
                return material;
            }
            else
            {
                // TODO FINISH THIS
                //objectFromDb.MaterialSerialNumber = material.MaterialSerialNumber;

                _db.Materials.Update(objectFromDb);
                _db.SaveChanges();

                return objectFromDb;
                
            }
        }
    }
}
