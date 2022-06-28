using System;
using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using System.IO;
using TMPro;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public static SystemManager instance;

    public string playerName;

    public int totalScore;

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

    [System.Serializable]
    public class SaveData
    {
         public string savePlayerName; 
         public int savedScore;
    };

    public void SaveName()
    {
        SaveData data = new SaveData();
        data.savePlayerName = playerName;
        data.savedScore = totalScore;

        string json = JsonUtility.ToJson(data);
    }

    public void LoadData()
    {
        string savePath  = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(savePath))
        {
            string loadJson = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(loadJson);

            totalScore = data.savedScore;
            playerName = data.savePlayerName;
        }
        // Debug.Log(totalScore + "123");
    }

}

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // ************Debugger****************
        // Debug.Log("Success2");
