using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    [SerializeField] Text highestScore;
    // Start is called before the first frame update
    void Start()
    {
        if(SystemManager.instance != null)
        {
            highestScore.text = "BestScore : " + SystemManager.instance.playerName + " ( " + SystemManager.instance.totalScore + " ) ";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public DisplayName()
    {
        
    }
}
