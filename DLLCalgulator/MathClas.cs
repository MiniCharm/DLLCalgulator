namespace DLLCalgulator
{
    public class MathClas
    {
        public MathClas()
        {
            
        }

        /// <summary>
        /// Udregner summen af a og b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet</returns>
        public int Add(int a, int b) 
        {
            return a + b;
        }

        /// <summary>
        /// Udregner resultatet af a minus b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Udregner resultatet af a ganget med b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet</returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// UDregner resultatet af a divideret med b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet</returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }

        public double SquareRoot(int a) 
        {
            return Math.Sqrt(a);
        }

    }
}
