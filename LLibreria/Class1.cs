namespace LLibreria
{
    public class Class1
    {
        /// <summary>
        /// Mètode que genera un número aleatori entre un màxim i un mínim
        /// </summary>
        /// <param name="x">Número mínim</param>
        /// <param name="y">Número màxim</param>
        /// <returns>Retorna un int aleatori dins del rang</returns>
        public static int Random(int x, int y)
        {
            Random random = new Random();
            return random.Next(x, y+1);
        }
        /// <summary>
        /// Mètode que comprova si un número està dins d'un rang
        /// </summary>
        /// <param name="max">Número màxim</param>
        /// <param name="min">Número mínim</param>
        /// <param name="num">Número a analitzar</param>
        /// <returns>Retorna T si esttà dins del rang</returns>
        public static bool InRange(int max, int min, int num)
        {
            return (num <= max) && (num >= min);
        }
    }
}
