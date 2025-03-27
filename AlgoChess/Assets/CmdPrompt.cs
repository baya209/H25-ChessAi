using System;
using UnityEngine;

public class CmdPrompt : MonoBehaviour
{
    Partie partie = new Partie();
    bool bouge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        bouge = partie.jouerCoup(1, 1, 1, 2, 1);
        partie.afficher();

        
    }
}
