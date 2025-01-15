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
    [SerializeField] float endTime;
    [HideInInspector] public bool done;
    bool die;
    bool confirm;
    [SerializeField] string sceneName;
    int sceneNumber;
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
            end(); 
        }
    }
    void end()
    {
        done = true;
        if (suspicion > 0 && !(confirmation > 7))
        {
            //you die and nothing is confirmed
            sceneNumber = 1;
        }
        else if (suspicion > 0 && confirmation > 7) 
        {
            //you die and confirm
            sceneNumber = 2;
        }
        else if (!(suspicion > 0) && !(confirmation > 7)) 
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
        endText.SetActive(true);
        yield return new WaitForSeconds(endTime);
        SceneManager.LoadScene(sceneName+sceneNumber);
    }
}
