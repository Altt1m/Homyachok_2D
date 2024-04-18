using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillHero : MonoBehaviour
{
    public GameObject Restart; //1
    public static bool killHero = false;
    public Text counterText;

    private void Awake()
    {
        killHero = false;
        counterText = (Text)GameObject.Find("Counter").GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {  //2
        if (other.gameObject.tag == "MaceKill")
        {
            killHero = true;
            Restart.SetActive(true); //3
            Move.i = 0;
        }
    }
}