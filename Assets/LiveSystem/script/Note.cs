using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public int NoteSpeed;

    void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * NoteSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EndLine"))
        {
            Destroy(this.gameObject);
        }
    }
}
