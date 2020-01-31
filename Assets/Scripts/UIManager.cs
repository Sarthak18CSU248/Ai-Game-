using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject player;
    public GameObject Start_Button;

    public void GameStart()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().OnClick_Start();
    }

    
    
}
