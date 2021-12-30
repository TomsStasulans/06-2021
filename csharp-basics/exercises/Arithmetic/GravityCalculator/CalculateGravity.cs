using System;

namespace GravityCalculator
{
    public class CalculateGravity
    {
        private double gravity = -9.81;
        private double initialVelocity = 0.0;
        private double fallingTime = 10.0;
        private double initialPosition = 0.0;

        public CalculateGravity()
        {

        }

        public double CalculateFinalPositionWhenFallingTenSeconds()
        {
            return 0.5 * -(Math.Pow(fallingTime, 2) * gravity) + initialPosition + initialVelocity;
        }
    }
}