//// TASK 5
//// Implement a ParticleRepeller class. A ParticleRepeller is a Particle, which pushes other particles away from it
//// (i.e. accelerates them in a direction, opposite of the direction in which the repeller is). The repeller has an
//// effect only on particles within a certain radius (see Euclidean distance)

namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RepellerParticleUpdater : ParticleUpdater
    {
        private List<Particle> particlesPerTick = new List<Particle>();
        private List<ParticleRepeller> repellersPerTick = new List<ParticleRepeller>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var currentParticle = p as ParticleRepeller;
            if (currentParticle != null)
            {
                this.repellersPerTick.Add(currentParticle);
            }
            else
            {
                this.particlesPerTick.Add(p);
            }

            return base.OperateOn(p);
        }

        public override void TickEnded()
        {
            foreach (var repeller in this.repellersPerTick)
            {
                var particlesInRange = this.particlesPerTick.Where(
                    pr => (Math.Abs(pr.Position.Row - repeller.Position.Row) <= repeller.Range) && (Math.Abs(pr.Position.Col - repeller.Position.Col) <= repeller.Range));

                foreach (var particle in particlesInRange)
                {
                    particle.Accelerate(this.ChangeSpeed(particle));                  
                }                
            }

            this.particlesPerTick.Clear();
            this.repellersPerTick.Clear();

            base.TickEnded();
        }        

        private MatrixCoords ChangeSpeed(Particle particle)
        {
            int newSpeedX = -2 * particle.Speed.Row;
            int newSpeedY = -2 * particle.Speed.Col;

            return new MatrixCoords(newSpeedX, newSpeedY);
        }
    }
}
