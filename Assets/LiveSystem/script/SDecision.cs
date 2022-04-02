using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDecision : DecisionLine
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LongNote")
        {
            Decision(other.gameObject.transform.parent.GetChild(0).position.z);
        }
    }
}
