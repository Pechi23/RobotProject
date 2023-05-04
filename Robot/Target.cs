using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Target
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public bool IsAlive { get { return Hp > 0; } }
        public Target(string name,int hp=0)
        {
            Name = name;
            Hp = hp;
        }

        public static Target Animals = new Target("Animal", 50);
        public static Target Humans = new Target("Human", 100);
        public static Target Superheroes = new Target("Superhero",300);
        public static Target Robots = new Target("Robot", 1000);

    }
}
