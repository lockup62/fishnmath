using UnityEngine;

public class StatsManager : MonoBehaviour
{
    // Variable to store the total correct addition
    public float totalCorrectAddition = 0f;

    private void Update()
    {
        // Find additionLevel1, additionLevel2, additionLevel3, additionLevel4, and additionLevel5 GameObjects by name
        GameObject additionLevel1 = GameObject.Find("additionLevel1");
        GameObject additionLevel2 = GameObject.Find("additionLevel2");
        GameObject additionLevel3 = GameObject.Find("additionLevel3");
        GameObject additionLevel4 = GameObject.Find("additionLevel4");
        GameObject additionLevel5 = GameObject.Find("additionLevel5");

        // Reset totalCorrectAddition to 0 at the beginning of each Update
        totalCorrectAddition = 0f;

        // Check if each GameObject is found and accumulate correct addition values
        if (additionLevel1 != null)
        {
            ButtonBehavior buttonBehavior1 = additionLevel1.GetComponent<ButtonBehavior>();
            if (buttonBehavior1 != null)
            {
                totalCorrectAddition += buttonBehavior1.correctAddition;
            }
            else
            {
                Debug.LogError("ButtonBehavior component not found on additionLevel1.");
            }
        }

        if (additionLevel2 != null)
        {
            ButtonBehavior buttonBehavior2 = additionLevel2.GetComponent<ButtonBehavior>();
            if (buttonBehavior2 != null)
            {
                totalCorrectAddition += buttonBehavior2.correctAddition;
            }
            else
            {
                Debug.LogError("ButtonBehavior component not found on additionLevel2.");
            }
        }

        if (additionLevel3 != null)
        {
            ButtonBehavior buttonBehavior3 = additionLevel3.GetComponent<ButtonBehavior>();
            if (buttonBehavior3 != null)
            {
                totalCorrectAddition += buttonBehavior3.correctAddition;
            }
            else
            {
                Debug.LogError("ButtonBehavior component not found on additionLevel3.");
            }
        }

        if (additionLevel4 != null)
        {
            ButtonBehavior buttonBehavior4 = additionLevel4.GetComponent<ButtonBehavior>();
            if (buttonBehavior4 != null)
            {
                totalCorrectAddition += buttonBehavior4.correctAddition;
            }
            else
            {
                Debug.LogError("ButtonBehavior component not found on additionLevel4.");
            }
        }

        if (additionLevel5 != null)
        {
            ButtonBehavior buttonBehavior5 = additionLevel5.GetComponent<ButtonBehavior>();
            if (buttonBehavior5 != null)
            {
                totalCorrectAddition += buttonBehavior5.correctAddition;
            }
            else
            {
                Debug.LogError("ButtonBehavior component not found on additionLevel5.");
            }
        }

        // Output the result (you can remove this line in the final version)
        Debug.Log("Total Correct Addition: " + totalCorrectAddition);
    }
}