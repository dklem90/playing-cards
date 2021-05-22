using System;

using System.Collections.Generic;

namespace PlayingCardsApp.Utils
{
    public static class Utilities
    {
        /// <summary>
        /// The Swap method swaps the the position of two elements in a given list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <typeparam name="T"></typeparam>
        public static void Swap<T>(List<T> list, int a, int b)
        {
            T tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }
    }
}