using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class completeCheck : MonoBehaviour
{
    public GameObject level1;
    public bool complete1;
    public GameObject level2;
    public bool complete2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;

    public bool complete3;
    public bool complete4;
    private int x = 0;
    public GameObject addTrophy;
    public GameObject subTrophy;
    public GameObject multiTrophy;
    public GameObject divTrophy;

    public GameObject trophyUnlocked;

    public GameObject[] allLevelButtons;
   //checking if levels are completed
    void Update()
    {
        if (level1.active == true)
        {
            complete1 = true;
            allLevelButtons[0].SetActive(true);
        }
        if (level2.active == true)
        {
            complete2 = true;
            allLevelButtons[1].SetActive(true);
        }
        if (level3.active == true)
        {
            complete3 = true;
            allLevelButtons[2].SetActive(true);
        }
        if (level4.active == true)
        {
            complete4 = true;
            allLevelButtons[3].SetActive(true);
        }
        if (level5.active == true)
        {
            if (x == 0)
            {
                trophyUnlocked.SetActive(true);
                Invoke("trophyUnlockedFunc", 3f);
            }
            addTrophy.SetActive(true);
        }


    }
    private void trophyUnlockedFunc()
    {
        x++;
        trophyUnlocked.SetActive(false);
    }
}
