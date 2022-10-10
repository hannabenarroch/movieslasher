using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public static DialogueManager _dmanager;

    public void ShowMessage(string content)
    {
        txt.text = content;
        StartCoroutine(MakeTextDisappear());
    }

    private IEnumerator MakeTextDisappear()
    {
        yield return new WaitForSeconds(5);
        txt.text = "";
    }

    // Start is called before the first frame update
    void Start()
    {
        _dmanager = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
