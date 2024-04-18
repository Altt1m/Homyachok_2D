using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public Transform character; //1
    private int speed = 8;

    private void OnMouseDrag() //2
    {
        if (!KillHero.killHero)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //3

            mousePos.x = mousePos.x < -2.1f ? -2.1f : mousePos.x;
            mousePos.x = mousePos.x > 2.1f ? 2.1f : mousePos.x;

            character.position = Vector2.MoveTowards(character.position,
            new Vector2(mousePos.x, character.position.y), speed * Time.deltaTime);

            //character.position = new Vector2(mousePos.x, character.position.y); //4
        }
    }
}

