using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeBar : MonoBehaviour
{

    public List<int> BarLife;

    public void Damage () {

        BarLife.Remove(0);

        if (!BarLife.Contains(0)) {
            UnityEditor.EditorApplication.isPlaying = false;
            print("game over");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++) {
            BarLife.Add(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
