using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRail : MonoBehaviour
{
    LineRenderer line;
    [SerializeField]
    List<Transform> notetransform;
    List<Vector3> notevector;
    void Start()
    {
        line = GetComponent<LineRenderer>();
        notevector[0] = notetransform[0].position;
        notevector[1] = notetransform[1].position;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        line.SetPosition(0, notevector[0]);
        line.SetPosition(1, notevector[1]);
    }

}
