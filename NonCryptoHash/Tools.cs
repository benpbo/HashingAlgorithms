using System;

namespace Hash
{
    static class Tools
    {
        /// <summary>
        /// Shuffles the first n indexes of an array
        /// </summary>
        /// <typeparam name="T">Type of the array elements</typeparam>
        /// <param name="arr">The array to be shuffled</param>
        /// <param name="n">The first n elements that will be shuffled</param>
        public static void Shuffle<T>(T[] arr, int n = 256)
        {
            if (n == 0) return;

            //recursive shuffle
            Shuffle(arr, --n);

            //random index
            Random rng = new Random();
            int rndIndex = rng.Next(n);

            //swap
            T tmp = arr[n];
            arr[n] = arr[rndIndex];
            arr[rndIndex] = tmp;
        }
    }
}
