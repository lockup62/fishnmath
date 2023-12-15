using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MultiLevelController : MonoBehaviour
{
    public TextMeshProUGUI randomNum1Text;
    public TextMeshProUGUI randomNum2Text;

    public TextMeshProUGUI correctText;
    public TextMeshProUGUI[] incorrectText;

    public Button correctMulButton;
    public Button[] incorrectMulButton;
    private int randomNum1;
    private int randomNum2;
    private int correctMul;
    void Start()
    {
        GenerateRandomNumbers();
        SetRandomButtonPositions();
        UpdateTextFields();


    }

    public void GenerateRandomNumbers()
    {
        randomNum1 = Random.Range(0, 11);
        randomNum2 = Random.Range(0, 11);
        correctMul = randomNum1 * randomNum2;
    }

    public void SetRandomButtonPositions()
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
        SetButtonPosition(correctMulButton, positions[0]);
        for (int i = 0; i < incorrectMulButton.Length; i++)
        {
            SetButtonPosition(incorrectMulButton[i], positions[i + 1]);
        }
    }

    public void SetButtonPosition(Button button, Vector2 position)
    {
        RectTransform rectTransform = button.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = position;
    }
    //updating the text to be correct
    public void UpdateTextFields()
    {
        randomNum1Text.text = randomNum1.ToString();
        randomNum2Text.text = randomNum2.ToString();

        correctText.text = correctMul.ToString();
        for (int i = 0; i <= incorrectText.Length; i++)
        {
            int x = Random.Range(0, 110);



            while (x == correctMul)
            {
                x = Random.Range(0, 110);
            }




            incorrectText[i].text = x.ToString();
        }
    }




    //Fisher-Yates shuffle algorithm that i found
    public void ShuffleArray(Vector2[] array)
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