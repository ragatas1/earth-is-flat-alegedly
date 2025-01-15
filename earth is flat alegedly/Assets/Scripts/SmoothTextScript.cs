using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class SmoothTextScript : MonoBehaviour
{
    [SerializeField] string[] lines;
    [SerializeField] int index;
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] float textSpeed;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "";
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
