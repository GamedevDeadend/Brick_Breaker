using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{

    [SerializeField]SystemManager systemManager;
    [SerializeField] GameObject InputText;
    string userName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            StoreName();
        }
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
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
        systemManager.SetStringValue(userName);
        
    }
};