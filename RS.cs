using System;
using System.Linq;

public static class Kata
{
    public static string Solution(string str)

    {
        char[] cArray = str.ToCharArray();

        string reverse = String.Empty;

        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;


    }


}