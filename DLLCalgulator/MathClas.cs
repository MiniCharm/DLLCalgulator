namespace DLLCalgulator
{
    public class MathClas
    {
        /// <summary>
        /// En tom constructor til MathClas
        /// </summary>
        public MathClas()
        {
            
        }

        /// <summary>
        /// Metode, som udregner summen af a og b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet som en int/et heltal</returns>
        public int Add(int a, int b) 
        {
            return a + b;
        }

        /// <summary>
        /// Metode, som udregner resultatet af a minus b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet som en int/ et heltal</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Metode, som udregner resultatet af a ganget med b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet som en int/et heltal</returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Metode, som udregner resultatet af a divideret med b
        /// </summary>
        /// <param name="a">Første værdi</param>
        /// <param name="b">Anden værdi</param>
        /// <returns>Resultatet som en int/et heltal</returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Metode, som udregner kvadratroden af et tal
        /// </summary>
        /// <param name="a"></param>
        /// <returns> Resultatet som en double</returns>
        public double SquareRoot(int a) 
        {
            return Math.Sqrt(a);
        }

    }
}
