using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public string NameScene;
    public void LoadLevel(string Game)

        {
        LevelManager.LoadLevel(NameScene);
        Debug.Log("Wczytano poziom" + Game);
        }
    }