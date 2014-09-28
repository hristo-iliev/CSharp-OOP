namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class AdvancedParticleOperator : ParticleUpdater
    {
        private List<Particle> currentTickParticles = new List<Particle>();
        private List<ParticleAttractor> currentTickAttractors = new List<ParticleAttractor>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var potentialAttractor = p as ParticleAttractor;
            if (potentialAttractor != null)
            {
                this.currentTickAttractors.Add(potentialAttractor);
            }
            else
            {
                this.currentTickParticles.Add(p);
            }
            
            return base.OperateOn(p);
        }

        public override void TickEnded()
        {
            foreach (var attractor in this.currentTickAttractors)
            {
                foreach (var particle in this.currentTickParticles)
                {
                    var currParticleToAttractorVector = attractor.Position - particle.Position;

                    int particleToAttrRow = currParticleToAttractorVector.Row;
                    particleToAttrRow = DecreaseVectorCoordToPower(attractor, particleToAttrRow);

                    int particleToAttrCol = currParticleToAttractorVector.Col;
                    particleToAttrCol = DecreaseVectorCoordToPower(attractor, particleToAttrCol);

                    var currAcceleration = new MatrixCoords(particleToAttrRow, particleToAttrCol);

                    particle.Accelerate(currAcceleration);
                }
            }

            this.currentTickParticles.Clear();
            this.currentTickAttractors.Clear();

            base.TickEnded();
        }

        private static int DecreaseVectorCoordToPower(ParticleAttractor attractor, int particleToAttrCoord)
        {
            if (Math.Abs(particleToAttrCoord) > attractor.AttractionPower)
            {
                particleToAttrCoord = (particleToAttrCoord / (int)Math.Abs(particleToAttrCoord)) * attractor.AttractionPower;
            }

            return particleToAttrCoord;
        }
    }
}
