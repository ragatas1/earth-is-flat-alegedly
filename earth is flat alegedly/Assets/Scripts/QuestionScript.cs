using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionScript : MonoBehaviour
{
    [SerializeField] Animator anim;
    SpriteRenderer sprite;
    GameObject logikk;
    LogicScript logikkScript;
    float suspicion;
    float confirmation;
    public string question;
    GameObject questionObject;
    TextMeshProUGUI questionText;
    [HideInInspector] public int choice;
    [Header("One")]
    public string answerOne;
    GameObject objectOne;
    TextMeshProUGUI textOne;
    [SerializeField] float suspicionOne;
    [SerializeField] float confirmationOne;
    [Header("Two")] 
    public string answerTwo;
    GameObject objectTwo;
    TextMeshProUGUI textTwo;
    [SerializeField] float suspicionTwo;
    [SerializeField] float confirmationTwo;
    [Header("Three")]
    public string answerThree;
    GameObject objectThree;
    TextMeshProUGUI textThree;
    [SerializeField] float suspicionThree;
    [SerializeField] float confirmationThree;
    [Header("Four")]
    public string answerFour;
    GameObject objectFour;
    TextMeshProUGUI textFour;
    [SerializeField] float suspicionFour;
    [SerializeField] float confirmationFour;
    [Header("Second")]
    public string questionTwo;
    bool second;
    bool done;
    BoxCollider2D box;
    [Header("Second One")]
    public string secondAnswerOne;
    [SerializeField] float secondSuspicionOne;
    [SerializeField] float secondConfirmationOne;
    [Header("Second Two")]
    public string secondAnswerTwo;
    [SerializeField] float secondSuspicionTwo;
    [SerializeField] float secondConfirmationTwo;
    [Header("Second Three")]
    public string secondAnswerThree;
    [SerializeField] float secondSuspicionThree;
    [SerializeField] float secondConfirmationThree;
    [Header("Second Four")]
    public string secondAnswerFour;
    [SerializeField] float secondSuspicionFour;
    [SerializeField] float secondConfirmationFour;


    // Start is called before the first frame update
    void Start()
    {
        logikk = GameObject.FindGameObjectWithTag("logic");
        logikkScript = logikk.GetComponent<LogicScript>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        choosen();
    }
    void choosen()
    {
        logikkScript.questionInstance = this;
        if (anim != null)
        {
            anim.SetTrigger("talk");
        }
        questionObject = GameObject.FindGameObjectWithTag("Question");
        questionText = questionObject.GetComponent<TextMeshProUGUI>();
        objectOne = GameObject.FindGameObjectWithTag("answer1");
        textOne = objectOne.GetComponent<TextMeshProUGUI>();
        objectTwo = GameObject.FindGameObjectWithTag("answer2");
        textTwo = objectTwo.GetComponent<TextMeshProUGUI>();
        objectThree = GameObject.FindGameObjectWithTag("answer3");
        textThree = objectThree.GetComponent<TextMeshProUGUI>();
        objectFour = GameObject.FindGameObjectWithTag("answer4");
        textFour = objectFour.GetComponent<TextMeshProUGUI>();
        if (!second)
        {
            questionText.text = question;
            textOne.text = answerOne;
            textTwo.text = answerTwo;
            textThree.text = answerThree;
            textFour.text = answerFour;
        }
        else
        {
            questionText.text = questionTwo;
            textOne.text = secondAnswerOne;
            textTwo.text = secondAnswerTwo;
            textThree.text = secondAnswerThree;
            textFour.text = secondAnswerFour;
        }

    }
    private void OnMouseEnter()
    {
        if (anim != null && !done)
        {
            anim.SetBool("handup",true);
        }
    }
    private void OnMouseExit()
    {
        if (anim != null && !done)
        {
            anim.SetBool("handup", false);
        }
    }
    public void sendit()
    {
        if (choice == 1)
        {
            suspicion = suspicionOne;
            confirmation = confirmationOne;
        }
        else if (choice == 2)
        {
            suspicion = suspicionTwo;
            confirmation = confirmationTwo;
        }
        else if (choice == 3)
        {
            suspicion = suspicionThree;
            confirmation = confirmationThree;
        }
        else if (choice == 4)
        {
            suspicion = suspicionFour;
            confirmation = confirmationFour;
        }
        textOne.text = "";
        textTwo.text = "";
        textThree.text = "";
        textFour.text = "";
        questionText.text = "";
        logikkScript.suspicion = logikkScript.suspicion + suspicion;
        logikkScript.confirmation = logikkScript.confirmation + confirmation;
        if (!second)
        {
            second = true;
        }
        else
        {
            box = gameObject.GetComponent<BoxCollider2D>();
            box.enabled = false;
            done = true;
        }
        logikkScript.questionsAnswered = logikkScript.questionsAnswered + 1;
        logikkScript.chekr();
    }
}
