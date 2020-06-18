﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public Button Replay;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = Replay.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
        
}
