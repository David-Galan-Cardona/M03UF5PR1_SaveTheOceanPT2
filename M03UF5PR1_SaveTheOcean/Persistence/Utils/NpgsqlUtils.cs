using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M03UF5PR1_SaveTheOcean.DTO;
using Microsoft.Extensions.Configuration;

namespace M03UF5PR1_SaveTheOcean.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }
        public static AnimalDTO GetAnimal(NpgsqlDataReader reader)
        {
            AnimalDTO c = new AnimalDTO
            {
                Name = reader.GetString(0),
                Superfamily = reader.GetString(1),
                Species = reader.GetString(2),
                Wheight = reader.GetInt32(3)
            };
            return c;
        }
    }
}
