using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Planets
    {
        public bool ContainsLife { get { return (Life.Where(x=> x.IsAlive)).Count() > 0; } }
        public int NumberOfAnimals { get; set; }
        public int NumberOfHumans { get; set; }
        public int NumberOfSuperHeroes { get; set; }
        public int NumberOfRobots { get; set; }
        public List<Target> Life { get; set; }
        public Planets(bool containsLife=false, int numberOfAnimals=0, int numberOfHumans=0, int numberOfSuperheroes=0, int numberOfRobots=0) 
        {
            NumberOfAnimals= numberOfAnimals;
            NumberOfHumans= numberOfHumans;
            NumberOfSuperHeroes= numberOfSuperheroes;
            NumberOfRobots = numberOfRobots;

            Life = new List<Target>();

            for (int i = 0; i < numberOfAnimals; i++)
                Life.Add(new Target("Animal", 50));

            for (int i = 0; i < numberOfHumans; i++)
                Life.Add(new Target("Human", 100));

            for (int i = 0; i < numberOfSuperheroes; i++)
                Life.Add(new Target("Superhero", 300));

            for (int i = 0; i < numberOfRobots; i++)
                Life.Add(new Target("Robot", 1000));
        }
        public Planets() : this(false)
        { }

        public static Planets Earth = new Planets(true,10,5,2,2);
        public static Planets Mercur = new Planets(false);
        public static Planets Venus = new Planets(true,5,2,1);
        public static Planets Mars = new Planets(true,0,3,0,2);

    }
}
