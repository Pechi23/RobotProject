using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    internal class GiantKillerRobot : IRobot
    {
        public bool Active { get { return Energy > 0; } private set { } }
        public int Energy { get; set; }
        public int EyeLaserIntensity { get; set; }
        public Planets TargetPlanet { get; set; }
        public Target[] Targets { get; set; }
        public Target CurrentTarget { get { return TargetPlanet.Life[CurrentTargetIndex]; }  }
        public int CurrentTargetIndex { get; set; }

        public GiantKillerRobot(int energy, int eyeLaserIntensity, Target[] targets, int currentTargetIndex)
        {
            Energy = energy;
            EyeLaserIntensity = eyeLaserIntensity;
            CurrentTargetIndex = currentTargetIndex;
        }

        public GiantKillerRobot():this(0,0,null,0)
        {

        }

        public void initialize()
        {
            Energy = 30;
            EyeLaserIntensity = Intensity.Headshot;
            CurrentTargetIndex = 0;
        }

        public void AcquireNextTarget()
        {
                if (CurrentTargetIndex + 1 > Planets.Earth.Life.Count)
                {
                    Console.WriteLine("There aren't any alive targets left!");
                }
                else
                    CurrentTargetIndex++;
            
        }

        public void FireLaserAt(Target target)
        {
            if (Active)
            {
                Energy--;
                //if(Targets.Contains(target))
                    target.Hp -= EyeLaserIntensity;
                //else
                //    AcquireNextTarget();

                Console.WriteLine($"Pow! One {target.Name} got {EyeLaserIntensity} damage! {Math.Max(target.Hp,0)} hp remains!");

                if (Energy <= 0)
                    Console.WriteLine($"The robot doesn't have energy anymore! He stopped!");
                if (target.Hp <= 0)
                {
                    Console.WriteLine($"One {target.Name} got killed!");
                }
                Thread.Sleep(200);
            }
        }
    }
}
