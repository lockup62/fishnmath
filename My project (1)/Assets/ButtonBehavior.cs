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

    public TextMeshProUGUI tempScore;
    public GameObject Question;
    public TextMeshProUGUI incorrect;
    public TextMeshProUGUI levelComplete;

    // Start is called before the first frame update
    
    void Start()
    {
        levelComplete.enabled = false;
        incorrect.enabled = false;
    }

    // Update is called once per frame
    public void addCorrectAddition()
    {
        correctAddition++;
        correctAdditionTemp++;
        tempScore.text = correctAdditionTemp.ToString();
        Time.timeScale = 1f;
        Question.SetActive(false);

        if (correctAdditionTemp == 10)
        {
            correctAdditionTemp = 0;
            levelComplete.enabled = true;
            Invoke("levelCompleteFunc", 5f);

        }


    }

    public void addIncorrectAddition()
    {
        incorrect.enabled = true;
        Invoke("hideText", 3f);
        Time.timeScale = 1f;
        Question.SetActive(false);

        incorrectAddition++;
        

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
}
