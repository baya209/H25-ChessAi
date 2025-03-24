using System;
using UnityEngine;

public class CmdPrompt : MonoBehaviour
{
    Partie partie = new Partie();
    bool bouge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         bouge = partie.jouerCoup(1, 1, 1, 2, 1);

        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bouge);

    }
}
