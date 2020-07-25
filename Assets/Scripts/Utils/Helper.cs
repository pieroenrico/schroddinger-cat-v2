using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Helper : MonoBehaviour
{

    public string label;
    public bool hideOnStart = false;

    // Start is called before the first frame update
    void Start()
    {
        if (hideOnStart)
        {
            gameObject.SetActive(false);
        }
    }

    void OnDrawGizmos()
    {
        if (label != null && label != "")
        {
            Handles.Label(transform.position, label);
        }
    }
}
