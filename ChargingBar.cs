using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargingBar : MonoBehaviour
{
    private float t = 2.0f;
    private float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time < t) {
            this.gameObject.transform.localScale += new Vector3((float) 0.9 * Time.deltaTime / 2, 0, 0);
        }

        else {
            Destroy(this.gameObject.transform.parent.gameObject);
        }

    }
}