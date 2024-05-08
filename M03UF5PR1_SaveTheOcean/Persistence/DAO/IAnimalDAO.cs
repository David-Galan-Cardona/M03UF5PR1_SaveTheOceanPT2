using M03UF5PR1_SaveTheOcean.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5PR1_SaveTheOcean.Persistence.DAO
{
    public interface IAnimalDAO
    {
        AnimalDTO GetAnimalBySpecies(string species);
        public IEnumerable<AnimalDTO> GetAllAnimals();
        void AddAnimal(AnimalDTO animal);
        void UpdateAnimal(AnimalDTO animal);
        void DeleteAnimal(string species);
    }
}
