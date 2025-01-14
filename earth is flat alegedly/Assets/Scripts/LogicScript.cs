using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public float suspicion;
    public float confirmation;
    public QuestionScript questionInstance;
    public int questionsAnswered;
    [SerializeField] int questionsToAnswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chekr()
    {
        if (questionsToAnswer <= questionsAnswered)
        {

        }
    }
}
