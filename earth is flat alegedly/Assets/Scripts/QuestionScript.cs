using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionScript : MonoBehaviour
{
    [HideInInspector] public float suspicion;
    [HideInInspector] public float confirmation;
    [SerializeField] string question;
    int choice;
    [Header("One")]
    [SerializeField] string answerOne;
    [SerializeField] float suspicionOne;
    [SerializeField] float confirmationOne;
    [Header("Two")]
    [SerializeField] string answerTwo;
    [SerializeField] float suspicionTwo;
    [SerializeField] float confirmationTwo;
    [Header("Three")]
    [SerializeField] string answerThree;
    [SerializeField] float suspicionThree;
    [SerializeField] float confirmationThree;
    [Header("Four")]
    [SerializeField] string answerFour;
    [SerializeField] float suspicionFour;
    [SerializeField] float confirmationFour;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sendit()
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
    }
}
