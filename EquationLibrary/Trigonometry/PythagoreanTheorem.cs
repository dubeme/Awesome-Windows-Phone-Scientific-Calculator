using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquationLibrary.Trigonometry
{
    public class PythagoreanTheorem : Equation
    {
        public double Hypothenus { get; set; }
        public double Opposite { get; set; }
        public double Adjacent { get; set; }

        public override string ToString()
        {
            return String.Format("(Hypothenus = {0}\nOpposite = {1}\nAdjacent = {2}\n",Hypothenus,Opposite,Adjacent);
        }
        /// <summary>
        /// Solve for the Hypothenus side of the right angle triangle.
        /// </summary>
        /// <returns>True if solved, else false.</returns>
        public bool solveHypothenus()
        {
            try
            {
                Hypothenus = Math.Sqrt(Math.Pow(Opposite, 2.0) + Math.Pow(Adjacent, 2.0));
                return true;
            }
            catch (Exception) { }
            return false;
        }

        /// <summary>
        /// Solve for the Opposite side of the right angle triangle.
        /// </summary>
        /// <returns>True if solved, else false.</returns>
        public bool solveOpposite()
        {
            try
            {
                Opposite = Math.Sqrt(Math.Pow(Hypothenus, 2.0) - Math.Pow(Adjacent, 2.0));
                return true;
            }
            catch (Exception) { }
            return false;
        }

        /// <summary>
        /// Solve for the Adjacent side of the right angle triangle.
        /// </summary>
        /// <returns>True if solved, else false.</returns>
        public bool solveAdjacent()
        {
            try
            {
                Adjacent = Math.Sqrt(Math.Pow(Hypothenus, 2.0) - Math.Pow(Opposite, 2.0));
                return true;
            }
            catch (Exception) { }
            return false;
        }
    }
}
