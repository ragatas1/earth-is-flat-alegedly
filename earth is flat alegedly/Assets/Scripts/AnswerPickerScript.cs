using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.U2D;

public class AnswerPickerScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] int answerNumber;
    GameObject logikk;
    LogicScript logikkScript;
    QuestionScript questionScript;
    TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        logikk = GameObject.FindGameObjectWithTag("logic");
        logikkScript = logikk.GetComponent<LogicScript>();
        txt = gameObject.GetComponent<TextMeshProUGUI>();
    }
    private void OnMouseEnter()
    {
        txt.fontSize = 50;
        Debug.Log("inn");
    }
    private void OnMouseExit()
    {

        Debug.Log("ut");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        txt.color = Color.black;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        txt.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        clicked();
    }
    void clicked()
    {
        questionScript = logikkScript.questionInstance;
        questionScript.choice = answerNumber;
        questionScript.sendit();
    }
}
