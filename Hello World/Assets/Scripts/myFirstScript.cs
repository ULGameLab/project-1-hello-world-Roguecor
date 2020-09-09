using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour 
{

    void Awake()
    {
        UnityEngine.Debug.Log("Awake function");
    }

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Start function");
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("Update function");
    }
}
