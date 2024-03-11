using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDetail : MonoBehaviour
{
    public GameObject weaponDetailCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Watching()
    {
        weaponDetailCanvas.SetActive(true);
    }

    public void NonWatching()
    {
        weaponDetailCanvas.SetActive(false);
    }

}
