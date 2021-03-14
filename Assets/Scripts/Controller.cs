//namespaces "bibliotheken"
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//zeile 7 und 8 deklarieren den anfang der deklaration
public class Controller : MonoBehaviour
{
    //variabeln sind speicherplatz für daten und können nicht ausserhalb von klassen deklariert werden
    //variabeln deklarieren (exessmodifier - datentyp - variable)
    //variabeln zuweisung = (name - zuweisungsoperator - wert)
    int tage;
    int nummer = 6;

    // Start is called before the first frame update
    // jetzt kommt die deklaration
    void Start()
    {
    //hier steht der code der ausgeführt werden soll (z.B MyName(); = MethodenAufruf)
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSceneA()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeSceneB()
    {
        SceneManager.LoadScene("02NumberScene");
     
    }

    public void ChangeSceneC()
    {
        SceneManager.LoadScene("00WelcomeScene");

    }

}

//Klassen in Klassen deklarieren kann man NICHT
//MethodenDeklaration besteht aus private string MyName(){}
//void-> man bekommt nichts retour
//strng--return; -> man bekommt was zurück
