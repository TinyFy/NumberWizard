using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public string NameScene;
    public void LoadLevel(string name)

        {
        LevelManager.LoadLevel(NameScene);
        Debug.Log("Wczytano poziom" + name);
        }
    }