using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public float suspicion;
    public float confirmation;
    public QuestionScript questionInstance;
    public int questionsAnswered;
    [SerializeField] int questionsToAnswer;
    [SerializeField] GameObject endText;
    bool altEnd;
    [SerializeField] GameObject altEndText;
    [SerializeField] float endTime;
    [HideInInspector] public bool done;
    [SerializeField] string sceneName;
    int sceneNumber;
    [SerializeField] float susToDie;
    [SerializeField] float confirmToConfirm;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sceneName + sceneNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chekr()
    {
        if (questionsToAnswer <= questionsAnswered)
        {
            end();
        }
        if (suspicion >= 5) 
        { 
            altEnd = true;
            end(); 
        }
    }
    void end()
    {
        done = true;
        if (suspicion > susToDie && !(confirmation > confirmToConfirm))
        {
            //you die and nothing is confirmed
            sceneNumber = 1;
        }
        else if (suspicion > susToDie && confirmation > confirmToConfirm) 
        {
            //you die and confirm
            sceneNumber = 2;
        }
        else if (!(suspicion > susToDie) && !(confirmation > confirmToConfirm)) 
        {
            //you survive and nothing is confirmed
            sceneNumber = 3;
        }
        else
        {
            //you survive and confirm
            sceneNumber = 4;
        }
        StartCoroutine(theEnd());
    }
    IEnumerator theEnd()
    {
        if (altEnd)
        {
            altEndText.SetActive(true);
        }
        else
        {
            endText.SetActive(true);
        }
        yield return new WaitForSeconds(endTime);
        SceneManager.LoadScene(sceneName+sceneNumber);
    }
}
