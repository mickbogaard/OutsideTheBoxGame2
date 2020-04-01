using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.03f;
    public string fullText;
    private string currentText = "";
    public bool startText = true;

    public int forLoop = 0;

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
            delay = 0.005f;
        }

        if(startText == true)
        {
            StartCoroutine(ShowText());
            delay = 0.03f;
            startText = false;
        }
    }

    IEnumerator ShowText(){
        if (startText == true)
        {
            for (forLoop = 0; forLoop <= fullText.Length; forLoop++)
            {
                currentText = fullText.Substring(0, forLoop);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);
                if(forLoop == fullText.Length)
                {
                    //delay = 0.07f;
                }
            }
        }
    }
}
