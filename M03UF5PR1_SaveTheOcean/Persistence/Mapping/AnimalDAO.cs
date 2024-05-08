using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M03UF5PR1_SaveTheOcean.DTO;
using M03UF5PR1_SaveTheOcean.Persistence.DAO;
using Npgsql;
using M03UF5PR1_SaveTheOcean.Persistence.Utils;

namespace M03UF5PR1_SaveTheOcean.Persistence.Mapping
{
    public class AnimalDAO : IAnimalDAO
    {
        private readonly string connectionString;

        public AnimalDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public AnimalDTO GetAnimalBySpecies(string species)
        {
            AnimalDTO animal = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"name\", \"superfamily\", \"species\", \"wheight\" FROM \"animals\" WHERE \"species\" = @Species";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Species", species);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // ORM: [--,--,--] -----> ContactDTO
                    animal = NpgsqlUtils.GetAnimal(reader);
                }
            }
            return animal;
        }
        public void AddAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "INSERT INTO \"animals\" (\"name\", \"superfamily\", \"species\", \"wheight\") VALUES (@Name, @Superfamily, @Species, @Wheight)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Superfamily", animal.Superfamily);
                command.Parameters.AddWithValue("@Species", animal.Species);
                command.Parameters.AddWithValue("@Wheight", animal.Wheight);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "UPDATE \"animals\" SET \"name\" = @Name, \"superfamily\" = @Superfamily, \"species\" = @Species, \"wheight\" = @Wheight WHERE \"species\" = @Species";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Superfamily", animal.Superfamily);
                command.Parameters.AddWithValue("@Species", animal.Species);
                command.Parameters.AddWithValue("@Wheight", animal.Wheight);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteAnimal(string species)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "DELETE FROM \"animals\" WHERE \"name\" = @Name";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", species);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<AnimalDTO> GetAllAnimals()
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"name\", \"superfamily\", \"species\", \"wheight\" FROM \"animals\"";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // ORM: [--,--,--] -----> ContactDTO
                    AnimalDTO player = NpgsqlUtils.GetAnimal(reader);
                    animals.Add(player);
                }
            }
            return animals;
        }
    }
}
