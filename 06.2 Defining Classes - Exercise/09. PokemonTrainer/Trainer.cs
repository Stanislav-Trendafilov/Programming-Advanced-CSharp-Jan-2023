using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons=new List<Pokemon>();
        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }
        public string Name { get { return name; } set { name = value; } }
        public int Badges { get { return badges; } set { badges = value; } }
        public List<Pokemon> Pokemons { get { return pokemons; } set { pokemons=value; } }

    }
}
