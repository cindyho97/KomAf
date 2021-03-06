﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinGame :MonoBehaviour{

    public short minimumA1;
    public short minimumA2;
    public short minimumA3;

    public Sprite pageFoundSprite;
    public Sprite redAImage;
    public Image pageImage;
    public Image A1Image;
    public Image A2Image;
    public Image A3Image;
    GameMaster gmScript;
    public Button menuButton;
    public Button restartButton;
    SceneController sceneConScript;

    void Start()
    {
        gmScript = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        sceneConScript = GameObject.FindGameObjectWithTag("SceneController").GetComponent<SceneController>();

        menuButton.onClick.AddListener(()=> sceneConScript.LoadAntwerpMap());
        restartButton.onClick.AddListener(()=> sceneConScript.RestartLevel());
    }

    //public short CountAPoints()
    //{
    //    short ACount = 0;
    //    if (gmScript) // clear error
    //    {
    //        if (gmScript.coins >= minimumA1)
    //        {
    //            ChangeASprite(A1Image);
    //            ACount += 1;
    //        }
    //        if (gmScript.coins >= minimumA2)
    //        {
    //            ChangeASprite(A2Image);
    //            ACount += 1;
    //        }
    //        if (gmScript.coins >= minimumA3)
    //        {
    //            ChangeASprite(A3Image);
    //            ACount += 1;
    //        }
    //    }
        
    //    return ACount;
    //}

    //void ChangeASprite(Image AImage)
    //{
    //    AImage.GetComponent<Image>().sprite = redAImage;
    //}

    public void ChangePageSprite()
    {
        pageImage.GetComponent<Image>().sprite = pageFoundSprite;
    }
}
