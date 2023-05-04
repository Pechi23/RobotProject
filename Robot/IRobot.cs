using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    interface IRobot
    {
        public bool Active { get; }
        public int Energy { get; }
        public int EyeLaserIntensity { get; set; }
        public Target[] Targets { get; set; }
        public Target CurrentTarget { get; }
        public Planets TargetPlanet { get; set; }
        public int CurrentTargetIndex { get; set; }
        public void initialize();
        public void FireLaserAt(Target target);
        public void AcquireNextTarget();
    }
}
