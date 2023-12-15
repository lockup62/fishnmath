using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonBehavior : MonoBehaviour
{
    public float correctAddition = 0f;
    public float correctSubtraction = 0f;
    public float correctMulti = 0f;
    public float correctDiv = 0f;
    

    public float correctAdditionTemp = 0f;
    public float correctSubtractionTemp = 0f;
    public float correctMultiTemp = 0f;
    public float correctDivTemp = 0f;


    public float incorrectAddition = 0f;
    public float incorrectSubtraction = 0f;
    public float incorrectMulti = 0f;
    public float incorrectDiv = 0f;

    public float incorrectAdditionTemp = 0f;
    public float incorrectSubtractionTemp = 0f;
    public float incorrectMultiTemp = 0f;
    public float incorrectDivTemp = 0f;

    public TextMeshProUGUI tempScore;
    public GameObject Question;
    public TextMeshProUGUI incorrect;
    public TextMeshProUGUI levelComplete;
    public TextMeshProUGUI levelFailed;

    public GameObject levelCompleted;
    public GameObject menu;
    public GameObject menuButton;
    public GameObject resumeButton;
    public GameObject pauseScreen;
    public GameObject currentLevel;
    public GameObject fishmanager;

    public GameObject trophyView;
    public GameObject statsView;




    void Start()
    {
        levelComplete.enabled = false;
        incorrect.enabled = false;
        levelFailed.enabled = false;
    }

    public void addCorrectAddition()
    {
        correctAddition++;
        correctAdditionTemp++;
        tempScore.text = correctAdditionTemp.ToString();
        Time.timeScale = 1f;
        Question.SetActive(false);

        if (correctAdditionTemp >= 7 && (correctAdditionTemp + incorrectAdditionTemp == 10))
        {
            correctAdditionTemp = 0;
            incorrectAdditionTemp = 0;
            levelCompleted.SetActive(true);
            levelComplete.enabled = true;
            Invoke("levelCompleteFunc", 5f);
            
        }
        else if (correctAdditionTemp < 7 && (correctAdditionTemp + incorrectAdditionTemp == 10))
        {


            correctAdditionTemp = 0;
            incorrectAdditionTemp = 0;
            levelFailed.enabled = true;
            Invoke("levelFailedFunc", 5f);
        }

    }

    public void addIncorrectAddition()
    {
        incorrect.enabled = true;
        Invoke("hideText", 3f);
        Time.timeScale = 1f;
        Question.SetActive(false);

        incorrectAddition++;
        incorrectAdditionTemp++;
        if (correctAdditionTemp >= 7 && (correctAdditionTemp + incorrectAdditionTemp == 10))
        {
            correctAdditionTemp = 0;
            incorrectAdditionTemp = 0;
            levelCompleted.SetActive(true);
            levelComplete.enabled = true;
            Invoke("levelCompleteFunc", 5f);


        }
        else if (correctAdditionTemp <= 7 && (correctAdditionTemp + incorrectAdditionTemp == 10))
        {


            correctAdditionTemp = 0;
            incorrectAdditionTemp = 0;
            levelFailed.enabled = true;
            Invoke("levelFailedFunc", 5f);

        }

    }
    public void addCorrectSubtraction()
    {
        correctSubtraction++;
        correctSubtractionTemp++;
        tempScore.text = correctSubtractionTemp.ToString();
        Time.timeScale = 1f;
        Question.SetActive(false);

        if (correctSubtractionTemp == 10)
        {
            correctSubtractionTemp = 0;
            levelComplete.enabled = true;
            Invoke("levelCompleteFunc", 5f);

        }


    }

    public void addIncorrectSubtraction()
    {
        incorrect.enabled = true;
        Invoke("hideText", 3f);
        Time.timeScale = 1f;
        Question.SetActive(false);

        incorrectSubtraction++;


    }
    public void addCorrectMulti()
    {
        correctMulti++;
        correctMultiTemp++;
        tempScore.text = correctMultiTemp.ToString();
        Time.timeScale = 1f;
        Question.SetActive(false);

        if (correctMultiTemp == 10)
        {
            correctMultiTemp = 0;
            levelComplete.enabled = true;
            Invoke("levelCompleteFunc", 5f);

        }


    }
    public void addIncorrectMulti()
    {
        incorrect.enabled = true;
        Invoke("hideText", 3f);
        Time.timeScale = 1f;
        Question.SetActive(false);

        incorrectMulti++;


    }
    public void addCorrectDiv()
    {
        correctDiv++;
        correctDivTemp++;
        tempScore.text = correctDivTemp.ToString();
        Time.timeScale = 1f;
        Question.SetActive(false);

        if (correctDivTemp == 10)
        {
            correctDivTemp = 0;
            levelComplete.enabled = true;
            Invoke("levelCompleteFunc", 5f);

        }


    }
    public void addIncorrectDiv()
    {
        incorrect.enabled = true;
        Invoke("hideText", 3f);
        Time.timeScale = 1f;
        Question.SetActive(false);

        incorrectDiv++;


    }

    void hideText()
    {
        incorrect.enabled = false;

    }

    void levelCompleteFunc()
    {
        levelComplete.enabled = false;
    }
    void levelFailedFunc()
    {
        levelFailed.enabled = false;
    }
    public void pauseFunc()
    {
        if (pauseScreen.active == true)
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
            menuButton.SetActive(false);
            resumeButton.SetActive(false);
        }
        else
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
            menuButton.SetActive(true);
            resumeButton.SetActive(true);

        }
    }
    //clicking the quit button after hitting the pause button
    public void menuButtonFunc()
    {
        currentLevel.SetActive(false);
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        menuButton.SetActive(false);
        resumeButton.SetActive(false);
        menu.SetActive(true);
        correctAdditionTemp = 0f;
        correctSubtractionTemp = 0f;
        correctMultiTemp = 0f;
        correctDivTemp = 0f;
        fishmanager.SetActive(true);
        incorrectAdditionTemp = 0f;
        incorrectSubtractionTemp = 0f;
        incorrectMultiTemp = 0f;
        incorrectDivTemp = 0f;
        


        GameObject[] fishManagerClones = GameObject.FindGameObjectsWithTag("FishManager");

        foreach (GameObject fishManagerClone in fishManagerClones)
        {
            Destroy(fishManagerClone);
        }


    }
    //resuming the game
    public void resume()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        menuButton.SetActive(false);
        resumeButton.SetActive(false);
    }

    public void stats()
    {
        statsView.SetActive(true);
    }
    //viewing and unviewing the trophy room
    public void toggleTrophy()
    {
        if (trophyView.active == false) {
            trophyView.SetActive(true);
            menu.SetActive(false);
        }
        else
        {
            trophyView.SetActive(false);
            menu.SetActive(true);
        }
      
    }
    
}
       


