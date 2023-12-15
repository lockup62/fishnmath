using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyRoom : MonoBehaviour

{
    public GameObject trophyRoom;
    public GameObject menu;

    // Start is called before the first frame update
    public void showRoom()
    {
        trophyRoom.SetActive(true);
        menu.SetActive(false);
    }
}
