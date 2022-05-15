using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;

    public float gameDifficultyLevel = 10;

    public int anotherValue = 5;

    public int anotherValue1 = 5;

    public int anotherValue2 = 5;

    private void Awake()
    {
        instance = this;

        //if (instance = null)
        //{


        //    //get data from database
        //}
        //else
        //{
        //    Destroy(this);
        //}

    }

}
