using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    // public = syns i Unity

    //int heltal
    public int testInt = 5;

    //float med komman upp till 8 siffror
    public float testFloat = 1.0f;

    //double dubbla floats storlek
    public double testDouble = 2.0d;

    //bool ja elr nej
    public bool testBool = true;

    //char ett tecken
    public char testChar = 's';

    //string flera tecken
    //public string testString = "hej";

    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float Number3;
    public float triangle;
    public float circle;
    public float delar;
    public string uppgift6;
    public float radius;
    public int demon;
    public int minDamage;
    public int maxDamage;
    public int antalDemoner;
    public bool Checked;
    public int MyIntValue = 10;
    public float UserValue = 1;
    public int Dice = 10;

    // Use this for initialization
    void Start()
    {

        if (Checked == true)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }

        

        //print(testint * testint);
        //print(testString);
        //print(11f / 2);
        //print(testBool);
        //Debug.LogError(5f / 2);

        //Uppgift1();
        //Uppgift5();
        //Uppgift3();
        //Sentence1();
        //Triangel();
        //Uppgift6();
        //Uppgift7();
        //Uppgift8();
    }
    //void Uppgift1()
    //{
    //    Debug.Log("hej");
    //    Debug.Log(string.Format("Svaret på (963 * 421) - (175463 / 87) = {0}", ((963f * 421f) - (175463f / 87f))));
    //}
    //void Sentence1()
    //{
    //    print(sentence1);
    //    print(sentence2);
    //    print(sentence3);
    //}

    //void Uppgift3()
    //{
    //    Debug.Log(string.Format(
    //        "Numret 5 upphöjt med {0} = {1} medans kvadratroten ur {0] = {2} ", 
    //        Number3, 
    //        (Mathf.Pow(5f, Number3)), 
    //        Mathf.Sqrt(Number3)));
    //}
    //void Triangel()
    //{
    //    Debug.Log(string.Format("Arean av en triangel med höjden 8 och basen {0} är {1}m^2", triangle, ((4 * 8) / 2)));
    //}

    //void Uppgift5()
    //{
    //    Debug.Log(string.Format("om du delar en tårta i delar med en vinkel på {0} så får du {1} delar", circle, (360 / circle)));
    //    Debug.Log(string.Format("om du delar en tårta i {0} delar kommer de ha vinkeln {1}", delar, (360 / delar)));
    //}
    //void Uppgift6()
    //{
    //    Debug.Log(string.Format("Boss {0} of Doom", uppgift6));
    //}

    //void Uppgift7()
    //{
    //    Debug.Log(string.Format(
    //        "Volymen på ett klot räknas ut genom 4 * π * radie^3 / 3 så om radien är {0} så blir volymen {1}", 
    //        radius, 4 * 3.14f * (radius * radius * radius) / 3 * 2978));
    //}
    //void Uppgift8()
    //{
    //    Debug.Log(string.Format(
    //        "Det finns {3} demoner, Demonerna har {2} HP var med en skada på {0} till {1} så kommer det ta i snitt {4}, denna gången tog det {2} slag att döda dem",
    //        minDamage, maxDamage, (demon * antalDemoner) / Random.Range(minDamage, maxDamage), antalDemoner, (minDamage * maxDamage) / 2));
    //}

    // Update is called once per frame
    void Update()
    {

        //if(Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    UserValue += 2;
        //}

        //if(Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    UserValue /= 2;
        //}
        
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    print(UserValue);
        //}

        if(Input.GetKeyDown(KeyCode.R))
        {
            Dice -= Random.Range(1, 7);
            Dice += Random.Range(1, 7);
        }
           

        // == lika med
        // != inte lika med 
        // <= mindre eller lika med
        // >= större eller lika med
        // < mindre än
        // > större än
        // && och (and)
        // || eller

        //if (MyIntValue == 10 || Checked == true)
        //{
            
        //    print("Måndag");
        //}
        //else if (MyIntValue == 9)
        //{
        //    print("Tisdag");
        //}
        //else
        //{
        //    print("Okänd dag");
        //}

        //if(Input.GetKeyDown(KeyCode.R))
        //{
        //    print("reload");
        //}

        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    print(Random.Range(0, 10));
        //    print("Lean Left");
        //}

        //Random.Range(0, 10);

    }
}