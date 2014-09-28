//// TASK 3
//// Create a ChickenParticle class. The ChickenParticle class moves like a ChaoticParticle,
//// but randomly stops at different positions for several simulation ticks and, for each of those stops,
//// creates (lays) a new ChickenParticle. You are not allowed to edit any existing class.

namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class ChickenParticle : ChaoticParticle
    {
        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator) :
            base(position, speed, randomGenerator)
        {           
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'C' } };
        }

        public override IEnumerable<Particle> Update()
        {
            var currentSpeed = this.Speed;
            int row = currentSpeed.Row;
            int col = currentSpeed.Col;
            if (row == 0 && col == 0)
            {
                IEnumerable<Particle> newChicken = base.Update();
                var listOfChickens = newChicken as List<Particle>;
                listOfChickens.Add(new ChickenParticle(this.Position, this.ChangeSpeed(), this.RandomGen));
                this.Speed = this.ChangeSpeed();
                
                return listOfChickens as IEnumerable<Particle>;
            }

            return this.Update();
        }
    }
}
