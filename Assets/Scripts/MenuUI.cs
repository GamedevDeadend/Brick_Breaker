using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using TMPro.Examples;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] GameObject InputText;

    string userName;

    // Update is called once per frame
    void Start()
    {
        SystemManager.instance.loadData();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StoreName();
        }
    }

    public void Play()
    {
        SystemManager.instance.loadData();
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void Quit()
    {
        SystemManager.instance.saveData();

        #if UNITY_EDITOR

        EditorApplication.ExitPlaymode();

        #else

            Application.Quit();

        #endif

    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    void StoreName()
    {
        userName = InputText.GetComponent<TextMeshProUGUI>().text;
        SystemManager.instance.playerName = userName;
    }
};


// *****Garbage Code******

// [SerializeField] Text scoreText;
// scoreText.text = "Best Score : " + userName + " : " + highScore;
// public int highScore;

// Start is called before the first frame update
// void Start()
// {

// }


//********DEBUGGER**************
    // Debug.Log(userName);
    // Debug.Log("failed");
