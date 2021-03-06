﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelPoint : StopPoint {

    public enum CurrentLevel
    {
        SintAnnastrand, ZwemvijverBoekenberg, Vlaeykensgang, DeRuien
    };
    public enum NextLevel
    {
        SintAnnastrand, ZwemvijverBoekenberg, Vlaeykensgang, DeRuien
    };
    public CurrentLevel currentLevel;
    public NextLevel nextLevel;
    public bool levelUnlocked;
    public int maxCoins;
    private Button levelButton;
    private SceneController sceneConScript;
	// Use this for initialization
	void Start () {
        sceneConScript = GameObject.FindGameObjectWithTag("SceneController").GetComponent<SceneController>();
    }

    //call this from stefan's script when navigator has reached this level instead of using a button
    public void HasClickedOnLevel()
    {
        sceneConScript.OpenLocationPopup(gameObject.name, maxCoins);
    }













}
