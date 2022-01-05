using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int size = 5;
        int spaces = size - 1;
        int numOfStars = 1;
        string stars = "";
        for (int i = 0; i < size; i++, numOfStars++, spaces--)
        {
            AddLineOfCharacters('-', spaces, ref stars);
            AddLineOfCharacters('*', numOfStars, ref stars);
            stars += '\n';
        }
        print(stars);

        if (size < 5)

            print(size);

    }
    void AddLineOfCharacters(char c, int length, ref string stars)
    {
        for (int i = 0; i < length; i++)
        {
            stars += c;
        }
    }

}
