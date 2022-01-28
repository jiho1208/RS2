using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public int NoteSpeed;
    public float Perfect = 0.49f;
    public float Great = 0.9f;
    public float Good = 1.19f;
    public float Bad = 1.5f;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Decision"))
        {
            if (Mathf.Abs(transform.position.z) <= Perfect)
            {
                Debug.Log("Perfect");
            }
            else if (Mathf.Abs(transform.position.z) <= Great)
            {
                Debug.Log("Great");
            }
            else if (Mathf.Abs(transform.position.z) <= Good)
            {
                Debug.Log("Good");
            }
            else if (Mathf.Abs(transform.position.z) <= Bad)
            {
                Debug.Log("Bad");
            }
            else
            {
                Debug.Log("Miss");
            }
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("EndLine"))
        {
            Debug.Log("miss");
            Destroy(this.gameObject);
        }

    }

    void Move()
    {
        transform.Translate(Vector3.down * Time.deltaTime * NoteSpeed);
    }
}
