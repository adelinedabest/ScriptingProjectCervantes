using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class ConventionsandSyntax : MonoBehaviour
{
    private static object GetDebuggerDisplay()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
    // Update is called once per frame
    void Update()
    {

        }
}