namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class ParticleSystemMain
    {
        private const int SimulationRows = 30;
        private const int SimulationCols = 40;

        private static readonly Random RandomGenerator = new Random();

        public static void Main(string[] args)
        {
            var renderer = new ConsoleRenderer(SimulationRows, SimulationCols);
            var particleOperator = new AdvancedParticleOperator();
            var particleOpRepeller = new RepellerParticleUpdater();

            var particles = new List<Particle>()
            {
                new Particle(new MatrixCoords(5, 5), new MatrixCoords(1, 0)),
                new ChickenParticle(new MatrixCoords(10, 10), new MatrixCoords(1, 0), RandomGenerator),
                new ParticleRepeller(new MatrixCoords(20, 5), new MatrixCoords(0, 0), 10)
                ////new ChaoticParticle(new MatrixCoords(10, 10), new MatrixCoords(1, 0), RandomGenerator)
                ////new ParticleEmitter(new MatrixCoords(5, 10), new MatrixCoords(0, 0), RandomGenerator),
                ////new ParticleEmitter(new MatrixCoords(5, 20), new MatrixCoords(0, 0), RandomGenerator),
                ////new VariousLifetimeParticleEmitter(new MatrixCoords(29, 1), new MatrixCoords(0, 0), RandomGenerator),

                ////new ParticleAttractor(new MatrixCoords(15, 8), new MatrixCoords(), 5),
                ////new ParticleAttractor(new MatrixCoords(15, 20), new MatrixCoords(), 1),
            };

            var engine = new Engine(renderer, particleOpRepeller, particles, 500);
            engine.Run();
        }
    }
}
