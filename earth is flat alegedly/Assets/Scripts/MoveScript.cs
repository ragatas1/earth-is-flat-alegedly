using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 addforce;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(addforce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
