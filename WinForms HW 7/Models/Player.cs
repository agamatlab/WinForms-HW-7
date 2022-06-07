using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_HW_7.Enums;

namespace WinForms_HW_7.Models
{

    public class Player
    {
        public Player(string? name, byte number, Position position)
        {
            Name = name;
            Number = number;
            Position = position;
        }

        public Guid ID { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public byte Number{ get; set; }
        public Position Position{ get; set; }
    }
}
