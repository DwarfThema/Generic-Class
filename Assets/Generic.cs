using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour
{
    void Start()
    {
        int[] result = Plus(1, 2);
        Debug.Log(result[0] + result[1]);
    }

    private int[] Plus(int firstElement, int secondElement)
    {
        return new int[] { firstElement, secondElement };
    }


}
