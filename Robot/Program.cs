using Robots;

var robot = new GiantKillerRobot();
robot.initialize();
robot.Targets = new Target[] { Target.Animals, Target.Humans, Target.Superheroes };

robot.EyeLaserIntensity = Intensity.Kill;

robot.TargetPlanet = Planets.Earth;
while (robot.Active && robot.TargetPlanet.ContainsLife)
    if (robot.CurrentTarget.IsAlive)
        robot.FireLaserAt(robot.CurrentTarget);
    else
        robot.AcquireNextTarget();

Console.WriteLine("There are no targets left! The robot won!");
