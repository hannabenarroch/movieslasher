using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotDie : MonoBehaviour
{
    void OnTriggerEnter(Collider thrown) {
        if (thrown.CompareTag("Carrot")){
            Destroy(this.gameObject);
            print("I'm dead ARGH");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
