using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonBehavior : MonoBehaviour
{
    public float correctAddition = 0f;
    public float correctAdditionTemp = 0f;
    public float incorrectAddition = 0f;
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
    void hideText()
    {
        incorrect.enabled = false;

    }
    void levelCompleteFunc()
    {
        levelComplete.enabled = false;
    }
}
