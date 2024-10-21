using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{

    int age = 21;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting age is " + age);
        int newAge = NextAge(age);
        Debug.Log("New age is " + newAge);
        newAge = afterYears(newAge, 7);
        Debug.Log("Age after seven years is " + newAge);
    }

   int NextAge(int currentAge)
    {
        return currentAge+=1;
    }

    int afterYears(int currentAge, int amount)
    {
        return currentAge += amount;
    }
}
