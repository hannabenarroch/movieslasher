using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwCarrot : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public ItemSO itemToCheck;
    public Transform placeToInstantiate;
    public float Distance;
    Vector3 Direction;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<Backpack>().IsInBag(itemToCheck)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Input.GetMouseButtonDown(1)){
                Direction = ray.GetPoint(Distance) - Player.transform.position;
                GameObject g = Instantiate(prefabToInstantiate, placeToInstantiate.position, Quaternion.identity);
                g.GetComponent<Rigidbody>().velocity = Direction;
                Player.GetComponent<Backpack>().RemoveItem(itemToCheck);
            }
        }
    }
}
