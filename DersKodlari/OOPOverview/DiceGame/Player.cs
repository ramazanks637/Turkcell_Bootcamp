using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Player
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Dice> DiceObject { get; set; } = new List<Dice>
    }
}
