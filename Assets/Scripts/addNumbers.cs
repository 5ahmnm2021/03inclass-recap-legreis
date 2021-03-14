using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField Num01;
    public InputField Num02;
    public Text Result;

    public void AddNumbersOnClick()
    {
        float Num1 = float.Parse(Num01.text);
        float Num2 = float.Parse(Num02.text);
        float addResult = Num1 + Num2;
        Result.text = addResult.ToString();
    }
}
