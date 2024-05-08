using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5PR1_SaveTheOcean.DTO
{
    public class PlayerDTO
    {
        public string Name { get; set; }
        public int Exp { get; set; }
        public PlayerDTO(string name, int exp)
        {
            Name = name;
            Exp = exp;
        }
        public PlayerDTO() { }
    }
}
