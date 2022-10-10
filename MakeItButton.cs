using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItButton : MonoBehaviour
{

    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;
    public GameObject prefabToInstantiate;
    public Transform placeToInstantiate;
    private bool picked_up = false;
    private float time = 0.0f;
    private float t = 2.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0)){
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject){

                time = 0.0f;
                unityEvent.Invoke();
                picked_up = true;
                GameObject g = Instantiate(prefabToInstantiate, placeToInstantiate, false);
            }
        }

        if (picked_up && time > t) {
            Destroy(this.gameObject);
        }

    }
}
