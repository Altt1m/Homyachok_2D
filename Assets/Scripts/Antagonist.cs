using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antagonist : MonoBehaviour
{
    public GameObject Mace;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!KillHero.killHero)//1
        {
            Instantiate(Mace, new Vector2(Random.Range(-2.1f, 2.1f), 2.5f), Quaternion.identity);//2
            yield return new WaitForSeconds(2f); //3
        }
    }
}
