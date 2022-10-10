using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goTowardsPlayer : MonoBehaviour
{
    public float speed;
    public float range_of_dmg;
    private GameObject Player;
    private lifeBar BarLife;
    private float time = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        BarLife = Player.GetComponent<lifeBar>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        Vector3 direction = Player.transform.position - this.gameObject.transform.position;

        if (direction.magnitude < range_of_dmg) {
            if (time > 1.0f) {
                BarLife.Damage();
                time = 0.0f;
            }
        }
        else {
            direction = direction / direction.magnitude;
            transform.Translate(direction * speed * Time.deltaTime);
        }
        
    }
}
