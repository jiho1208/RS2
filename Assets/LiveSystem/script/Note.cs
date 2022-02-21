using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public int NoteSpeed;
    public float Perfect = 0.49f;
    public float Great = 0.9f;
    public float Good = 1.19f;
    public float Bad = 1.5f;
    public List<Sprite> DisionImage;
    public Image DisionUI;
    private float zPos;
    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.CompareTag("Decision"))
        {
            zPos = Mathf.Abs(transform.position.z);
            if (zPos <= Perfect)
            {
                Debug.Log("Perfect");
            }
            else if (zPos <= Great)
            {
                Debug.Log("Great");
            }
            else if (zPos <= Good)
            {
                Debug.Log("Good");
            }
            else if (zPos <= Bad)
            {
                Debug.Log("Bad");
            }
            else
            {
                Debug.Log("Miss");
            }
            Destroy(this.gameObject);
        }
*/
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





