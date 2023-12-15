using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AdditionLevelController : MonoBehaviour
{
    public TextMeshProUGUI randomNum1Text;
    public TextMeshProUGUI randomNum2Text;

    public TextMeshProUGUI correctText;
    public TextMeshProUGUI[] incorrectText;

    public Button correctSumButton;
    public Button[] incorrectSumButton;
    private int randomNum1;
    private int randomNum2;
    private int correctSum;
    void Start()
    {
        GenerateRandomNumbers();
        SetRandomButtonPositions();
        UpdateTextFields();

    
    }

    private void GenerateRandomNumbers()
    {
        randomNum1 = Random.Range(0, 11);
        randomNum2 = Random.Range(0, 11);
        correctSum = randomNum1 + randomNum2;
    }

    private void SetRandomButtonPositions()
    {
        //Creating an array of the positions
        Vector2[] positions = new Vector2[]
        {
            new Vector2(-163.9f, -100.5f),
            new Vector2(-68f, -100.5f),
            new Vector2(30.1f, -100.5f),
            new Vector2(113.2f, -100.5f)
        };

        //shuffling it with an alg i found from stackoverflow for shuffling the array
        ShuffleArray(positions);

        //Assigning each button to a shuffled position
        SetButtonPosition(correctSumButton, positions[0]);
        for (int i = 0; i <incorrectSumButton.Length; i++)
        {
            SetButtonPosition(incorrectSumButton[i], positions[i + 1]);
        }
    }

   private void SetButtonPosition(Button button, Vector2 position)
    {
        RectTransform rectTransform = button.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = position;
    }

    private void UpdateTextFields()
    {
        randomNum1Text.text = randomNum1.ToString();
        randomNum2Text.text = randomNum2.ToString();

        correctText.text = correctSum.ToString();
        for (int i = 0; i < incorrectText.Length; i++)
        {
            int x = Random.Range(0, 21);



            while (x == correctSum)
            {
                x=Random.Range(1, 21);
            }




            incorrectText[i].text = x.ToString();
        }
     }
    

    void OnCorrectSumButtonClick()
    {
        // will do later
    }

    void OnIncorrectSumButtonClick()
    {
        // will do later
    }

    //Fisher-Yates shuffle algorithm
    private void ShuffleArray(Vector2[] array)
    {
        int n = array.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            Vector2 temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}