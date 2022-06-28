using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public static SystemManager instance;

    public string playerName;

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

    void Update()
    {
    }

}

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // ************Debugger****************
        // Debug.Log("Success2");
        // Debug.Log(playerName + "123");
