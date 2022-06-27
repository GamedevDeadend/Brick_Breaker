using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public static SystemManager instance;

    public string userNameRef;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

    }

     public void SetStringValue (string sample)
    {
        userNameRef = sample;
        Debug.Log("Success2");
    }
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
