using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SA_UnitZpos : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            Vector3 tPos = new Vector3((int)transform.position.x, (int)transform.position.y, transform.position.y * 0.1f);
            transform.localPosition = tPos;
        }
        else
        {
            transform.localPosition = new Vector3(transform.position.x, transform.position.y, transform.position.y * 0.1f);

        }
    }
}
