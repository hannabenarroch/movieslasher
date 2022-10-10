using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAction : MonoBehaviour
{
    public ItemSO item;
    private GameObject Player;
    private bool balise = false;
    float t = 2.0f;
    float time = 0.0f;

    public void buttonMethod() {
        Player = GameObject.FindWithTag("Player");
        Player.GetComponent<Backpack>().AddItem(item);
        balise = true;
    }

    void Update () {
        if (balise) {
            time += Time.deltaTime;
            if (time < t) {
                Player.GetComponent<FPSController>().canMove = false;
            }
            else {
                Player.GetComponent<FPSController>().canMove = true;
                balise = false;
                time = 0.0f;
            }
        }
    }
}
