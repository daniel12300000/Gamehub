using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollow : MonoBehaviour
{
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Head");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
    }
}
