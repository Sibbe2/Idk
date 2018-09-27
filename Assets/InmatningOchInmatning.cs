using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InmatningOchInmatning : MonoBehaviour {

    public float UserValue = 1;
    public int Dice = 10;
    public float DragonHP;
    public float Player = 100;
    public float Dragon2;
    public float Dragon2HP;
    public float DragonHit;
    public int PlayerMinDamage;
    public int PlayerMaxDamage;
    public int PlayerCritChance;


    // Use this for initialization
    void Start () {
        DragonHP = Random.Range(100, 150);
        Dragon2 = Random.Range(0, 10);
        if (Dragon2 <= 0)
        {
            Dragon2HP = Random.Range(100, 150);
        }

        PlayerMaxDamage = Random.Range(0, 151);
        PlayerMinDamage = Random.Range(0, 151);

        PlayerCritChance = Random.Range(0, 20);

    }
	
	// Update is called once per frame
	void Update () {

        //Uppgift1
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


        //Uppgift 2
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    Dice -= Random.Range(1, 7);
        //    Dice += Random.Range(1, 7);
        //}
        //if (Dice >= 20)
        //{
        //    print("You Win");
        //}
        //else if (Dice <= 0)
        //{
        //    print("You lose");
        //}

        //Uppgift3

        if(PlayerMinDamage >= PlayerMaxDamage)
        {
            PlayerMinDamage = Random.Range(0, 151);
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            DragonHP -= Random.Range(PlayerMinDamage, PlayerMaxDamage);
            Dragon2HP -= Random.Range(PlayerMinDamage, PlayerMaxDamage);
            DragonHit = Random.Range(0, 2);
            if(PlayerCritChance <= 0)
            {
                DragonHP -= 151;
                Dragon2HP -= 151;
            }

        }
        if(Input.GetKeyDown(KeyCode.Space) && DragonHit >= 1)
        {
            Player -= Random.Range(5, 25);
            if(Dragon2 <= 0)
            {
                Player -= Random.Range(5, 25);
            }
        }

        if(DragonHP <= 0 && Dragon2HP <= 0)
        {
            print("Player Won");
        }
        else if(Player <= 0)
        {
            print("Dragon Won");
        }

       
       

    }
}
