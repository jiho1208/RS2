using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{


    void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EndLine"));
        {
            Destroy(this.gameObject);
            Debug.Log("good");
        }
    }
}
