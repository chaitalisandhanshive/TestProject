using System.Collections.Generic;

namespace _3DModels.Models
{
    public interface IModelAccessories
    {
        IEnumerable<ModelAccessories> GetModelAccessories();
        ModelAccessories GetModelAccessoriesById(int id);
        void AddModelAccessories(ModelAccessories modelAccessories);
        void UpdateModelAccessories(ModelAccessories modelAccessories);
        void DeleteModelAccessories(int id);
    }
}
