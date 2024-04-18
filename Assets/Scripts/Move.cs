using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField] //1 
    private float speed = 2f; // 2
    public Text counterText;
    public static int i = 0;

    private void Start()
    {
        counterText = (Text)GameObject.Find("Counter").GetComponent<Text>();
    }

    void Update()
    {
        if (transform.position.y < -4.3f)
        {
            Destroy(gameObject); // 3
            if (!KillHero.killHero)
            {
                i++;
                counterText.text = i.ToString();
            }
        }
            
        transform.position -= new Vector3(0, speed * Time.deltaTime, 0); //4
    }
}
