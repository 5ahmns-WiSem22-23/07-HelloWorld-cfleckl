using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    int startValue = 0;

    int startValue_2;

    int startValue_3 = 10;

    int startValue_4 = 20;

    void Start()
    {
        Debug.Log("Hallo Methoden!");

        Debug.Log("before startValue: " + startValue);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue);

        Debug.Log("before startValue: " + startValue_2);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after startValue: " + startValue_2);

        Debug.Log("before startValue: " + startValue_3);
        DecrementByOne(startValue_3);
        Debug.Log("after startValue: " + startValue_3);

        Debug.Log("before startValue: " + startValue_4);
        startValue_4 = DecrementByX(startValue_4, 5);
        Debug.Log("before startValue: " + startValue_4);
    }

    int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    void IncrementByX(int valToAdd)
    {
        startValue_2 += valToAdd;
    }


    void IncrementByOne()
    {
        startValue++;
    }

}