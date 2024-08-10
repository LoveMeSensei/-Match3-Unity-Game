using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] A = { -1 , 1 };
        Debug.Log(Pair(A));
    }

    public int Solution(int[] A, int L, int R)
    {
        int count = 0;
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == R)
            {
                count++;
            }
        }

        for(int i = 0; i < count; i++)
        {
            if(10)
        }
    }


    public bool Pair(int[] A)
    {
        int count = 0;

        if (A.Length == 2)
        {
            if (A[0] + A[1] == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool hasNeg = false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                hasNeg = true;
                break;
            }
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (hasNeg)
            {
                if (A[i] % 2 != 0)// so le
                {
                    count++;
                }
            }
            else
            {
                if (A[i] % 2 == 0)// so chan
                {
                    count++;
                }
            }
        }

        if (count > A.Length / 2)
        {
            return false;
        }

        return true;
    }
}
