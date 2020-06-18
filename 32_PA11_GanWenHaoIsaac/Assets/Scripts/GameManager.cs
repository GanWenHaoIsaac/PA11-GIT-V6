using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager thisManager = null;
    [SerializeField] private Text Txt_Score = null;
    private int Score = 0;  
    
    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int value)
    {
        Score++;
        Txt_Score.text = "Score : " + Score;
    }
}
