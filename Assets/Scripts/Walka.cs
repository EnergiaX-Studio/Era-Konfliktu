using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.W))
        {
            test1();
        }
    }
    public void test1(){
        Squad a1=new Squad (10,10,10,10);
        Squad a2=new Squad (8,8,8,8);
        Debug.Log(a1.Atak(a1,a2));
        Debug.Log(a2.Atak(a2,a1));
    }
}
public class Squad{
    string name;
    float  attack, defense, damage, health;
        public Squad(float squadAttack, float squadDefense, float squadDamage, float squadHealth)
    {
        attack = squadAttack;
        defense = squadDefense;
        damage = squadDamage;
        health = squadHealth;
    }
        public float Atak(Squad attacker, Squad defender)
    {
        float dmgFromAttacker = attacker.damage+ (attacker.attack-defender.defense)*0.1f*attacker.damage;
        defender.health-=dmgFromAttacker;
        return dmgFromAttacker;
    }
}
