using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRail : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(asdf());
    }

    void Update()
    {

    }

    IEnumerator asdf()
    {
        WaitForSeconds Wait = new WaitForSeconds(1f);
        while (transform.localScale.y > 0)
        {
            transform.position += new Vector3(0, 0, 1);
            transform.localScale -= new Vector3(0, 2, 0);
            yield return Wait;
        }
    }
}
