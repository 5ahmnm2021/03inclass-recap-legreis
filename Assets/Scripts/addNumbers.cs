﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField Num01;
    public InputField Num02;
    public Text Result;
    public Text Error;

    public float num1;
    public float num2;

    public void AddNumbersOnClick()
    {
        try
        {
            num1 = float.Parse(Num01.text);
        }
        catch (System.Exception)
        {
            Num01.image.color = new Color32(225, 0, 0, 100);
            Error.text = "Gib eine Zahl ein!";
        }
        try
        {
            num2 = float.Parse(Num02.text);
        }
        catch (System.Exception)
        {
            Num02.image.color = new Color32(255, 0, 0, 100);
            Error.text = "Gib eine Zahl ein!";
        }

        //float addResult = num1 + num2;
        Result.text = (num1 + num2).ToString();
        Debug.Log("Das Ergebnis ist: " + Result.text);

    }
}
