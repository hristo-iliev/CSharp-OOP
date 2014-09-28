//// TASK 5
//// Implement a ParticleRepeller class. A ParticleRepeller is a Particle, which pushes other particles away from it
//// (i.e. accelerates them in a direction, opposite of the direction in which the repeller is).
//// The repeller has an effect only on particles within a certain radius (see Euclidean distance)

namespace ParticleSystem
{
    using System;

    public class ParticleRepeller : Particle
    {        
        private int range;        

        public ParticleRepeller(MatrixCoords position,  MatrixCoords speed, int range) : base(position, speed)
        {
            if (range < 0)
            {
                throw new ArgumentException("Invalid ParticleRepeller range. Must be non-negative number");
            }

            this.range = range;            
        }

        public int Range
        {
            get { return this.range; }
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'R' } };
        }
    }
}
