using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class3palindrome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "tayaabcbaayat";
        for (int i = 0; i < str.Length; i++)
        {
            for(int j = 1; i+j < str.Length; j++)
            {
                string s = str.Substring(i, j);
                if(CheckWord(s))
                {
                    print(s);
                }
            }
        }
    }
    bool CheckWord(string s)
    {
        int lr = 0;
        int hi = s.Length - 1;
        while (lr < hi)
        {
            if (s[lr] != s[hi])
            {
                return false;
                lr++;
                hi++;
            }
             return true;
        }
        return false;
    }
}
