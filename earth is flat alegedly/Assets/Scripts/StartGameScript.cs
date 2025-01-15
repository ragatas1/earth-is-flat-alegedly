using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    [SerializeField] float whenStartGame;
    [SerializeField] string scene;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startGem());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator startGem()
    {
        yield return new WaitForSeconds(whenStartGame);
        SceneManager.LoadScene(scene);
    }
}
