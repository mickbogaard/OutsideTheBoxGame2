using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.07f;
    public string fullText;
    private string currentText = "";
    public bool startText = true;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        //fullText =  state.GetStateText();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            delay = 0.03f;
        }

        if(startText == true)
        {
            StartCoroutine(ShowText());
            startText = false;
        }
    }

    IEnumerator ShowText(){
        if (startText == true)
        {
            for (int i = 0; i <= fullText.Length; i++)
            {
                currentText = fullText.Substring(0, i);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);
                if(i == fullText.Length)
                {
                    delay = 0.07f;
                }
            }
        }
    }
}
