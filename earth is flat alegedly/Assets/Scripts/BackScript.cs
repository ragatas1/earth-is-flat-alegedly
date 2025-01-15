using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    [SerializeField] string scene;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(scene);
    }
}
