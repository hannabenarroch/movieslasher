using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestruction : MonoBehaviour
{
    public float t;
    private float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > t) {
            Destroy(this.gameObject);
        }
    }
}
