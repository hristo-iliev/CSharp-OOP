//// TASK 1
//// Create a ChaoticParticle class, which is a Particle, randomly changing its movement (Speed). 
//// You are not allowed to edit any existing class.

namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;
    
    public class ChaoticParticle : Particle
    {
        private const int MovingInGivenDirection = 3;

        private Random randomGen;
        private int movesInGivenDirection;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator) :
            base(position, speed)
        {
            this.randomGen = randomGenerator;
            this.movesInGivenDirection = MovingInGivenDirection;
        }
                
        protected Random RandomGen
        {
            get { return this.randomGen; }
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'Q' } };
        }

        public override IEnumerable<Particle> Update()
        {
            this.movesInGivenDirection--;
            if (this.movesInGivenDirection == 0)
            {
                this.movesInGivenDirection = MovingInGivenDirection;
                this.Speed = this.ChangeSpeed();
            }            

            return this.Update();
        }

        protected MatrixCoords ChangeSpeed()
        {
            var newCoords = new MatrixCoords();
            newCoords.Row = this.randomGen.Next(-1, 2);
            newCoords.Col = this.randomGen.Next(-1, 2);

            return newCoords;
        }
    }
}
