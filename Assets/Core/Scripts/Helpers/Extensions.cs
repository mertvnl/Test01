using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public static class Extensions
{
    public static T GetRandom<T>(this List<T> list)
    {
        return list[UnityEngine.Random.Range(0, list.Count)];
    }

    public static T GetRandom<T>(this T[] array)
    {
        return array[UnityEngine.Random.Range(0, array.Length)];
    }

    //public static void Shuffle<T>(this IList<T> list)
    //{
    //    RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
    //    int n = list.Count;
    //    while (n > 1)
    //    {
    //        byte[] box = new byte[1];
    //        do provider.GetBytes(box);
    //        while (!(box[0] < n * (Byte.MaxValue / n)));
    //        int k = (box[0] % n);
    //        n--;
    //        T value = list[k];
    //        list[k] = list[n];
    //        list[n] = value;
    //    }
    //}

    private static System.Random rng = new System.Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
