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

    [System.Serializable]
    public class SaveData
    {
         public string savePlayerName; 
         public int savedScore;
    };

    public void saveData()
    {
        SaveData data = new SaveData();
        data.savePlayerName = playerName;
        data.savedScore = totalScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void loadData()
    {
        string savePath  = Application.persistentDataPath + "/savefile.json";
        // Debug.Log(playerName + "lol :)" );
        if(File.Exists(savePath))
        {
            string loadJson = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(loadJson);

            playerName = data.savePlayerName;
            Debug.Log(playerName + "lohjl :)");
            totalScore = data.savedScore;
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
